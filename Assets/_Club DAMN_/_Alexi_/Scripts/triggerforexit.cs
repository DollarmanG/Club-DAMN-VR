using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerforexit : MonoBehaviour
{

    [SerializeField]
    private GameObject exitcylinder;
    private void OnTriggerEnter(Collider other)
    {
        // Kontrollera om det �r r�tt objekt som nuddar triggerboxen
        if (other.CompareTag("Player"))
        {
            exitcylinder.SetActive(true);
        }
    }
}
