using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounceranimscript : MonoBehaviour
{
    [SerializeField]
    private Animator animbouncer;

    [SerializeField]
    private BoxCollider triggerBoxForBouncer;

    [SerializeField]
    private GameObject IDcard;




    void BacktoIdle()
    {
        animbouncer.SetBool("Istalking", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("IDcard"))
        {
            animbouncer.SetBool("Istalking", true);
            triggerBoxForBouncer.enabled = false;

        }
    }
}
