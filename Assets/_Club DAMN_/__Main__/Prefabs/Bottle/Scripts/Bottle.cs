using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField] GameObject brokenBottlePrefab;
    private Rigidbody rb;
    private bool hasCollided = false;

    // Ange tröskelhastighet och tröskelkollisionshastighet.
    public float explosionThresholdVelocity = 10.0f;
    public float collisionThresholdVelocity = 5.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!hasCollided && rb.velocity.magnitude >= explosionThresholdVelocity)
        {
            Explode();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude >= collisionThresholdVelocity)
        {
            hasCollided = true;
            Explode();
        }
    }


    void Explode()
    {
        GameObject brokenBottle = Instantiate(brokenBottlePrefab, transform.position, Quaternion.identity);
        brokenBottle.GetComponent<BrokenBottle>().RandomVelocities();
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/BottleBrake");
        Destroy(gameObject);
    }
}