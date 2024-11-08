using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerAnimation : MonoBehaviour
{
    private Animator animator; 

    private void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        
        if (Input.GetButtonDown("Fire2"))
        {
            animator.SetTrigger("fall"); 
        }
        else
        {
            animator.SetTrigger("Idle"); 
        }

        if (Input.GetButtonDown("Jump")) 
        {
            animator.SetTrigger("Jump"); 
        }
        else 
        {
            animator.SetTrigger("Idle");
        }

        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Hit"); 
        }
        else
        {
            animator.SetTrigger("Idle"); 
        }
        
        if (Input.GetButtonDown("Fire3"))
        {
            animator.SetTrigger("DoubleJump");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        
        if (Input.GetButtonDown("Horizontal"))
        {
            animator.SetTrigger("Run"); 
        }
        else
        {
            animator.SetTrigger("Idle"); 
        }
        
        if (Input.GetButtonDown("Fire4"))
        {
            animator.SetTrigger("WallJump"); 
        }
        else
        {
            animator.SetTrigger("Idle"); 
        }
    }
}