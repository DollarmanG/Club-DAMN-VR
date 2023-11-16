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

    [SerializeField]
    private BoxCollider triggerBoxForHello;

    public Transform beerSpawnPoint; // Create a reference to the spawn location in the Unity editor

    public Gamemanager1 gamemanager1;

    private bool beerSpawned = true; // A bool variable to check if the beer has spawned

    void Start()
    {
        gamemanager1 = FindObjectOfType<Gamemanager1>();
    }

    private void Backtoidlebar2()
    {
        bartendergivesbeer.SetBool("Isgivingbeer", false);
        triggerBoxForId.enabled = true;
        if (!beerSpawned)
        {
            SpawnBeerPrefab(); // Call the function to spawn the beer if it hasn't already spawned
            beerSpawned = true; // Mark that the beer has spawned
        }
    }



    public void SpawnBeerPrefab()
    {
        Instantiate(beerPrefab, beerSpawnPoint.position, beerSpawnPoint.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("IDcard") && gamemanager1.isWaveingAnimationComplete)
        {
            bartendergivesbeer.SetBool("Isgivingbeer", true);
            triggerBoxForId.enabled = false;
            triggerBoxForHello.enabled = false;
        }
    }


}