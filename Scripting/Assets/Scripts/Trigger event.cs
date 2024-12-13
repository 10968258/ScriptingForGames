using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggerevent : MonoBehaviour
{
    public UnityEvent triggerEvent;
    
    private void OnTriggerEnter(Collider other)
        {
            triggerEvent.Invoke();
            Debug.Log("Player interacted with the object!");
            }
}