using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
void OnCollisionEnter(Collision collision)
{
    Debug.Log("Collision detected with " + collision.gameObject.name);
}
}