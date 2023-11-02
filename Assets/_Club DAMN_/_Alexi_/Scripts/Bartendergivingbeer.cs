using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bartendergivingbeer : MonoBehaviour
{
    [SerializeField]
    private Animator bartendergivesbeer;

    [SerializeField]
    private GameObject beerPrefab;

    [SerializeField]
    private BoxCollider triggerBoxForId;

    private bool isGivingBeer = false;

    private void Backtoidlebar2()
    {
        bartendergivesbeer.SetBool("Isgivingbeer", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isGivingBeer && other.gameObject.CompareTag("IDcard"))
        {
            bartendergivesbeer.SetBool("Isgivingbeer", true);
            triggerBoxForId.enabled = false;
            isGivingBeer = true;

            // Starta en Coroutine för att aktivera beerPrefab efter 3 sekunder.
            StartCoroutine(ActivateBeerPrefabAfterDelay(6f));
        }
    }

    private IEnumerator ActivateBeerPrefabAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Aktivera beerPrefab efter fördröjning.
        beerPrefab.SetActive(true);
    }
}