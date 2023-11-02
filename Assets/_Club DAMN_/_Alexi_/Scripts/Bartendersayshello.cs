using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bartendersayshello : MonoBehaviour
{
    [SerializeField]
    private Animator bartenderwaveing;

    [SerializeField]
    private BoxCollider triggerBoxForBartender;

    [SerializeField]
    private BoxCollider triggerBoxForId;

    [SerializeField]
    private GameObject IDcard;



    void Backtoidlebar1()
    {

        bartenderwaveing.SetBool("Iswaveing", false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bartenderwaveing.SetBool("Iswaveing", true);
            triggerBoxForBartender.enabled = false;
            IDcard.SetActive(true);
            triggerBoxForId.enabled = true;

        }
    }
}
