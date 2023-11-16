using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using static UnityEditor.ShaderData;

public class DJSlider : MonoBehaviour
{
    [SerializeField] private Transform minPoint, maxPoint;
    [SerializeField] float currentPoint;



    private void Awake()
    {

        FMODUnity.RuntimeManager.GetBus("bus:/Music");
    }
    void Update()
    {

        ChangeBase();

    }

    public void ChanhrVolume()
    {

    }


    void ChangeBase()
    {
        float normalizedValue = Mathf.InverseLerp(minPoint.position.z, maxPoint.position.z, transform.position.z);

        currentPoint = normalizedValue;
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Bass", currentPoint);
    }

}

