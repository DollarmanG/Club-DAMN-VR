using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quitgamescript : MonoBehaviour
{
    // Ange namnet p� scenen du vill byta till
    public string targetScene;

    private void OnTriggerEnter(Collider other)
    {
        // Kontrollera om det �r r�tt objekt som nuddar triggerboxen
        if (other.CompareTag("Player"))
        {
            // Byt till den angivna scenen
            SceneManager.LoadScene(targetScene);
        }
    }
}
