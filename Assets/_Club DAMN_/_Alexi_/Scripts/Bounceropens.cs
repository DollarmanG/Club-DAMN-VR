using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounceropens : MonoBehaviour
{
    [SerializeField]
    private Animator animbouncer;

    [SerializeField]
    private Animator rope;

    [SerializeField]
    private BoxCollider triggerBoxForId;

    [SerializeField]
    private BoxCollider triggerBoxforHello;

    [SerializeField]
    private BoxCollider BoxcolliderforWall;

    private bool isOpened = false;

    public Gamemanager1 gamemanager1;

    void Start()
    {
        gamemanager1 = FindObjectOfType<Gamemanager1>();
    }


    void Backtoidle()
    {
        animbouncer.SetBool("Isopening", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isOpened && other.gameObject.CompareTag("IDcard") && gamemanager1.IsTalkingAnimationComplete)
        {
            animbouncer.SetBool("Isopening", true);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Characters/Anthony Thank");
            rope.SetBool("Ropeopen", true);
            triggerBoxForId.enabled = false;
            BoxcolliderforWall.enabled = false;
            isOpened = true;
        }
    }


}
