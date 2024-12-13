using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    public Simplefloatdata healthData;

    public void ReduceHealth(float amount)
    {
        healthData.UpdateValue(amount);
    }
}