using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnOnOffDjBoard : MonoBehaviour
{

    [SerializeField] FMODUnity.StudioEventEmitter onIffSound;
    [SerializeField] GameObject songNames;
    [SerializeField] GameObject logga;
    public static bool isOff = false;



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
        /*
                foreach (var item in songs)
                {
                    item.Stop();
                }*/
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
