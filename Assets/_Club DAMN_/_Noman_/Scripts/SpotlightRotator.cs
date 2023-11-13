using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightRotator : MonoBehaviour
{
    public List<GameObject> objectsToRotate;
    public float rotationSpeed = 1.0f;
    public float changeInterval = 2.0f;

    private Dictionary<GameObject, Quaternion> targetRotations = new Dictionary<GameObject, Quaternion>();
    private float timer = 0.0f;

    void Start()
    {
        
        foreach (var obj in objectsToRotate)
        {
            targetRotations[obj] = RandomRotation();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeInterval)
        {
            timer = 0.0f;
            
            foreach (var obj in objectsToRotate)
            {
                targetRotations[obj] = RandomRotation();
            }
        }

        
        foreach (GameObject obj in objectsToRotate)
        {
            Quaternion targetRotation = targetRotations[obj];
            obj.transform.rotation = Quaternion.Lerp(obj.transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
    }

    Quaternion RandomRotation()
    {
        return Quaternion.Euler(Random.Range(-45f, 45f), Random.Range(-45f, 45f), 0);
    }
}
