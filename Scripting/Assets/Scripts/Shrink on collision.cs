using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinkoncollision : MonoBehaviour
{
    public float shrinkspeed = .5f;

    void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= shrinkspeed;
    }

}
