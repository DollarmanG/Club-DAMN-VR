using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    [SerializeField] GameObject alanWalker;



    public void HideShowObj()
    {
        if (alanWalker.activeInHierarchy)
        {
            alanWalker.SetActive(false);
        }

        else
        {
            alanWalker.SetActive(true);

        }
    }
}
