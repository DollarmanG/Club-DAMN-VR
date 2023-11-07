using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDcardteleportsback : MonoBehaviour
{
    public Transform targetObject; // H�r anger du det objekt som ID-kortet ska f�lja

    // Anropa denna funktion n�r du vill uppdatera positionen
    public void UpdatePosition()
    {
        if (targetObject != null)
        {
            // F� m�l-objektets position och till�mpa den p� ID-kortet
            transform.position = targetObject.position;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }

    // �vrig kod och funktioner i din script

    // Exempel p� hur du kan anropa UpdatePosition-funktionen fr�n en annan funktion
    public void AnropaUppdateringsfunktion()
    {
        UpdatePosition();
    }
}
