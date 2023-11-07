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

    public Transform beerSpawnPoint; // Skapa en referens till spawnplatsen i Unity-editorn

    public Gamemanager1 gamemanager1;

    private bool beerSpawned = true; // En bool-variabel för att kontrollera om ölen har spawnat

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
            SpawnBeerPrefab(); // Anropa funktionen för att skapa ölen om den inte redan har spawnat
            beerSpawned = true; // Markera att ölen har spawnat
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