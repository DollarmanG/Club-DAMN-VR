using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour
{

    [SerializeField][Range(-12f, 12f)] private float pitch;
    [SerializeField][Range(-80f, 10f)] private float musicVolume;

    //Base
    [SerializeField] private Transform bassMinPoint, bassMaxPoint, bassCurrentPoint;
    [SerializeField] private Transform volumeMinPoint, volumeMaxPoint, volumeCurrentPoint;
    [SerializeField] private Transform pitchMinPoint, pitchMaxPoint, pitchCurrentPoint;

    private float volumeFloatValue, bassFloatValue, pitchFloatValue;

    private FMOD.Studio.Bus music;

    private void Awake()
    {

        music = FMODUnity.RuntimeManager.GetBus("bus:/Music");
    }



    private void Update()
    {
        VolumeSlider();
        Pitchlider();

        BassSlider();

    }


    void VolumeSlider()
    {
        float totalDistance = Vector3.Distance(volumeMinPoint.position, volumeMaxPoint.position);


        float distanceAC = Vector3.Distance(volumeMaxPoint.position, volumeCurrentPoint.position);


        float t = Mathf.Clamp01(distanceAC / totalDistance);


        float result = Mathf.Lerp(-80f, 10f, t);

        volumeFloatValue = result;
        music.setVolume(Volume(volumeFloatValue));
    }

    void BassSlider()
    {
        float normalizedValue = Mathf.InverseLerp(bassMinPoint.position.z, bassMaxPoint.position.z, bassCurrentPoint.position.z);

        bassFloatValue = normalizedValue;
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Bass", bassFloatValue);


    }
    void Pitchlider()
    {
        float totalDistance = Vector3.Distance(pitchMinPoint.position, pitchMaxPoint.position);


        float distanceAC = Vector3.Distance(pitchMaxPoint.position, pitchCurrentPoint.position);


        float t = Mathf.Clamp01(distanceAC / totalDistance);


        float result = Mathf.Lerp(-12f, 12f, t);


        pitchFloatValue = result;
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Pitch", pitchFloatValue);



    }


    public float Volume(float db)
    {
        float linear = Mathf.Pow(10.0f, db / 20f);
        return linear;
    }
}
