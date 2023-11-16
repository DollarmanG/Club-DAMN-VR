using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnthonyTalk : MonoBehaviour
{
    private bool hasPlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasPlayed && other.gameObject.CompareTag("Player"))
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Characters/Anthony Leg");
            hasPlayed = true;
        }
    }
}
