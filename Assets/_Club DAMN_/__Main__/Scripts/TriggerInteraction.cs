using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    [SerializeField] GameObject alanWalker, xrOriginDj, xrOriginGuest, canvas;



    public void HideShowObj()
    {
        if (xrOriginDj.activeInHierarchy)
        {
            alanWalker.SetActive(true);
            xrOriginDj.SetActive(false);
            xrOriginGuest.SetActive(true);
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canvas.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canvas.SetActive(false);

        }
    }

    public void SwitchPlayer()
    {

        alanWalker.SetActive(false);
        xrOriginGuest.SetActive(false);
        xrOriginDj.SetActive(true);
        canvas.SetActive(false);
    }

    public void HideCanvas()
    {
        canvas.SetActive(false);

    }
}
