using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DJBoardInteractable : MonoBehaviour
{
    [SerializeField] Transform visualTarget;
    private XRBaseInteractable interactable;
    private Vector3 offset;
    private Vector3 initialLocalPose;
    [SerializeField] float resetSpeed = 5;
    [SerializeField] Vector3 localAxis;
    private Transform pokeAttachTransfomr;
    private bool isFallowign = false;
    private bool freeze = false;

    [SerializeField] float fallowAngel;




    // Start is called before the first frame update
    void Start()
    {
        initialLocalPose = visualTarget.localPosition;
        interactable = GetComponent<XRBaseInteractable>();
        interactable.hoverEntered.AddListener(Fallow);
        interactable.hoverExited.AddListener(Reset);
        interactable.selectEntered.AddListener(Freeze);
    }

    public void Fallow(BaseInteractionEventArgs arg0)
    {
        if (arg0.interactorObject is XRPokeInteractor)
        {
            XRPokeInteractor interactor = (XRPokeInteractor)arg0.interactorObject;

            pokeAttachTransfomr = interactor.attachTransform;
            offset = visualTarget.position - pokeAttachTransfomr.position;


            float pokeAngel = Vector3.Angle(offset, visualTarget.TransformDirection(localAxis));
            if (pokeAngel < fallowAngel)
            {
                isFallowign = true;
                freeze = false;
            }
        }
    }

    public void Reset(BaseInteractionEventArgs arg0)
    {
        if (arg0.interactorObject is XRPokeInteractor)
        {
            isFallowign = false;
            freeze = false;


        }
    }
    public void Freeze(BaseInteractionEventArgs arg0)
    {
        if (arg0.interactorObject is XRPokeInteractor)
        {
            freeze = true;


        }
    }

    // Update is called once per frame
    void Update()
    {
        if (freeze)
            return;
        if (isFallowign)
        {
            Vector3 localTargetPosition = visualTarget.InverseTransformPoint(pokeAttachTransfomr.position + offset);
            Vector3 constrainedLocalTargetPosition = Vector3.Project(localTargetPosition, localAxis);

            visualTarget.position = visualTarget.TransformPoint(constrainedLocalTargetPosition);
        }
        else
        {
            visualTarget.localPosition = Vector3.Lerp(visualTarget.localPosition, initialLocalPose, Time.deltaTime * resetSpeed);
        }
    }
}
