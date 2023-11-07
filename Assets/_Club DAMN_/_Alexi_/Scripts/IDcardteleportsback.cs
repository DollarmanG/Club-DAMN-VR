using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDcardteleportsback : MonoBehaviour
{
    public Transform targetObject; // Här anger du det objekt som ID-kortet ska följa

    // Anropa denna funktion när du vill uppdatera positionen
    public void UpdatePosition()
    {
        if (targetObject != null)
        {
            // Få mål-objektets position och tillämpa den på ID-kortet
            transform.position = targetObject.position;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }

    // Övrig kod och funktioner i din script

    // Exempel på hur du kan anropa UpdatePosition-funktionen från en annan funktion
    public void AnropaUppdateringsfunktion()
    {
        UpdatePosition();
    }
}
