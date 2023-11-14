using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    [SerializeField] GameObject alanWalker, xrOriginDj, xrOriginGuest;



    public void HideShowObj()
    {
        if (xrOriginDj.activeInHierarchy)
        {
            alanWalker.SetActive(true);
            xrOriginDj.SetActive(false);
            xrOriginGuest.SetActive(true);
        }

        else
        {
            alanWalker.SetActive(false);
            xrOriginDj.SetActive(true);
            xrOriginGuest.SetActive(false);

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            alanWalker.SetActive(false);
            xrOriginDj.SetActive(true);
            xrOriginGuest.SetActive(false);

        }
    }
}
