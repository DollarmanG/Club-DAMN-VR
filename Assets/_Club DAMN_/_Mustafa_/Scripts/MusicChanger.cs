using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour
{

    [SerializeField] FMODUnity.EventReference[] fmodEvent;
    [SerializeField][Range(-12f, 12f)] private float pitch;
    [SerializeField][Range(0, 1)] private float bass;
    [SerializeField][Range(-80f, 10f)] private float musicVolume;

    private FMOD.Studio.EventInstance instance;
    private FMOD.Studio.Bus music;
    private void Awake()
    {

        music = FMODUnity.RuntimeManager.GetBus("bus:/Music");
    }

    private void Start()
    {
        foreach (var eventFmod in fmodEvent)
        {
            instance = FMODUnity.RuntimeManager.CreateInstance(eventFmod);
            instance.start();
        }

    }

    private void Update()
    {
        music.setVolume(Volume(musicVolume));
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Pitch", pitch);
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Bass", bass);


    }

    public float Volume(float db)
    {
        float linear = Mathf.Pow(10.0f, db / 20f);
        return linear;
    }


}
