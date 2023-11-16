using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDcardteleportsback : MonoBehaviour
{
    public Transform targetObject; // Here you specify the object that the ID card should follow

    // Call this function when you want to update the position
    public void UpdatePosition()
    {
        if (targetObject != null)
        {

            // Get the target object's position and apply it to the ID card
            transform.position = targetObject.position;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }

    public void AnropaUppdateringsfunktion()
    {
        UpdatePosition();
    }
}
