using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnthonyTalk : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            FMODUnity.RuntimeManager.PlayOneShot("event:/Characters/Anthony Leg");


        }
    }
}
