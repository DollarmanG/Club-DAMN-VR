using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{

    [SerializeField] List<FMODUnity.StudioEventEmitter> tracks = new List<FMODUnity.StudioEventEmitter>();
    int trackToPlay = 0;
    private bool isPaused = true;
    private TextMeshProUGUI textColor;
    [SerializeField] int newNumberToplay;


    private void Start()
    {
        trackToPlay = Random.Range(0, tracks.Count);
        tracks[trackToPlay].Play();


        textColor = tracks[trackToPlay].gameObject.GetComponentInChildren<TextMeshProUGUI>();
        textColor.color = Color.green;

    }


    public void PlayCurrentTrack()
    {
        FMOD.RESULT result = tracks[trackToPlay].EventInstance.getPaused(out isPaused);


        if (!tracks[trackToPlay].IsPlaying())
        {
            trackToPlay = Random.Range(0, tracks.Count);
            tracks[trackToPlay].Play();
            //   textColor.color = Color.green;
        }

        else if (result == FMOD.RESULT.OK)
        {
            ResumeCurrentTrack();
            textColor.color = Color.green;

        }


    }
    public void PauseCurrentTrack()
    {
        tracks[trackToPlay].EventInstance.setPaused(true);
        tracks[newNumberToplay].EventInstance.setPaused(true);
        textColor.color = Color.yellow;


    }

    public void ResumeCurrentTrack()
    {
        tracks[trackToPlay].EventInstance.setPaused(false);
        tracks[newNumberToplay].EventInstance.setPaused(false);
        textColor.color = Color.green;

    }
    public void StopCurrentTrack()
    {
        tracks[trackToPlay].Stop();
        tracks[newNumberToplay].Stop();
        textColor.color = Color.white;
    }

    public void PlayButton(int numberPlay)
    {

        newNumberToplay = numberPlay;



        if (!tracks[numberPlay].IsPlaying())
        {

            foreach (var item in tracks)
            {
                item.Stop();
                item.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.white; ;

                textColor.color = Color.white;

            }

            tracks[numberPlay].Play();
            textColor = tracks[numberPlay].gameObject.GetComponentInChildren<TextMeshProUGUI>();
            textColor.color = Color.green;

        }
        else if (tracks[numberPlay].IsPlaying())
        {

            foreach (var item in tracks)
            {
                item.Stop();
                item.gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.white; ;

                textColor.color = Color.white;

            }


        }




    }


    public void HoverColourChange()
    {
        textColor = tracks[newNumberToplay].gameObject.GetComponentInChildren<TextMeshProUGUI>();
        textColor.color = Color.grey;
    }
    /*
    private void OnDestroy()
    {
        tracks[trackToPlay].Stop();
    }*/
}
