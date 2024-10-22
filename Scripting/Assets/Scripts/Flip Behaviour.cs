using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTransformBehaviour : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Flip();
    }

    private void Flip()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal > 0)
        {
            spriteRenderer.flipX = false; // Face right
        }
        else if (moveHorizontal < 0)
        {
            spriteRenderer.flipX = true; // Face left
        }
    }
}