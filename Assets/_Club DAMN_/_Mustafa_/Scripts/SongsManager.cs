using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongsManager : MonoBehaviour
{
    [SerializeField] FMODUnity.StudioEventEmitter[] songs;
    [SerializeField] FMODUnity.StudioEventEmitter song;
    [SerializeField] FMODUnity.StudioEventEmitter onIffSound;
    [SerializeField] GameObject songNames;
    [SerializeField] GameObject logga;
    public bool isOff = false;



    public void StopSong()
    {
        foreach (var item in songs)
        {
            item.Stop();
        }
    }

    public void PlayPause()
    {
        foreach (var emitter in songs)
        {


            if (!emitter.IsPlaying() && isOff)
            {
                Pause(false);

                emitter.Play();
            }
            else if (emitter.IsPlaying())
            {

                Pause(true);

            }
        }

    }

    public void Pause(bool state)
    {
        foreach (var emitter in songs)
        {
            var instance = emitter.EventInstance;
            instance.setPaused(state);
        }
    }

    public void TurnOnAndOff()
    {
        if (!isOff)
        {
            StartCoroutine(TurnOn());



        }


        if (isOff)
        {

            StartCoroutine(TurnOFf());



        }
    }



    IEnumerator TurnOFf()
    {

        foreach (var item in songs)
        {
            item.Stop();
        }
        songNames.SetActive(false);


        logga.SetActive(true);
        yield return new WaitForSeconds(4f);
        logga.SetActive(false);
        isOff = false;




    }



    IEnumerator TurnOn()
    {
        onIffSound.Play();
        logga.SetActive(true);
        yield return new WaitForSeconds(7f);
        logga.SetActive(false);

        songNames.SetActive(true);
        isOff = true;

    }


}
