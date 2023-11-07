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

    private bool saidhello = false;

    public Gamemanager1 gamemanager1;


    void Start()
    {
        gamemanager1 = FindObjectOfType<Gamemanager1>();
    }

    void Backtoidlebar1()
    {

        bartenderwaveing.SetBool("Iswaveing", false);
        gamemanager1.isWaveingAnimationComplete = true; // Sätt flaggan när animationen är klar.

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!saidhello && other.gameObject.CompareTag("Player"))
        {
            bartenderwaveing.SetBool("Iswaveing", true);
            triggerBoxForBartender.enabled = false;
            triggerBoxForId.enabled = true;
            saidhello = true;
            
        }
    }
}
