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
    private BoxCollider BoxcolliderforWall;


    void Backtoidle()
    {
        animbouncer.SetBool("Isopening", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("IDcard"))
        {
            animbouncer.SetBool("Isopening", true);
            rope.SetBool("Ropeopen", true);
            triggerBoxForId.enabled = false;
            BoxcolliderforWall.enabled = false;




        }
    }


}
