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
    private BoxCollider triggerBoxForId;

    [SerializeField]
    private GameObject IDcard;




    void TalkingtoIdle()
    {
        animbouncer.SetBool("Istalking", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animbouncer.SetBool("Istalking", true);
            triggerBoxForBouncer.enabled = false;
            IDcard.SetActive(true);
            triggerBoxForId.enabled = true;

        }
    }
}
