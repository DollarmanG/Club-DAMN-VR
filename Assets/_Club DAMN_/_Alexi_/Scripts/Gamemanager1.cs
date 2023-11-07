using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager1 : MonoBehaviour
{
    private bool isTalkingAnimationComplete = false;
    public bool isWaveingAnimationComplete = false;

    public bool IsTalkingAnimationComplete
    {
        get { return isTalkingAnimationComplete; }
        set { isTalkingAnimationComplete = value; }
    }

    public bool IsWaveingAnimationComplete
    {
        get { return isWaveingAnimationComplete; }
        set { isWaveingAnimationComplete = value; }
    }

    // Lägg till andra nödvändiga funktioner för att hantera spelets logik här.
}