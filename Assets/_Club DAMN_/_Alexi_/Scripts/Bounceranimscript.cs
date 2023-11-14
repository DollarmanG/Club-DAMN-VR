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

    public Gamemanager1 gamemanager1;


    void Start()
    {
        gamemanager1 = FindObjectOfType<Gamemanager1>();
    }

    void TalkingtoIdle()
    {
        animbouncer.SetBool("Istalking", false);
        gamemanager1.IsTalkingAnimationComplete = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animbouncer.SetBool("Istalking", true);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Characters/Anthony Leg");
            triggerBoxForBouncer.enabled = false;
            triggerBoxForId.enabled = true;

        }
    }
}
