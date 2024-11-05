using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerAnimation : MonoBehaviour
{
    private Animator animator; // Declare animator variable

    private void Start()
    {
        animator = GetComponent<Animator>(); // Use the correct variable name
    }

    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        // Check for horizontal input
        if (Input.GetButtonDown("Fire2"))
        {
            animator.SetTrigger("fall"); // Use correct variable name and remove "name:"
        }
        else
        {
            animator.SetTrigger("Idle"); // Fix missing closing quote
        }

        // Check for jump input
        if (Input.GetButtonDown("Jump")) // Remove the semicolon
        {
            animator.SetTrigger("Jump"); // Use correct variable name and fix capitalization
        }

        // Check for wall jump input
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Hit"); // Fix missing semicolon
        }
    }
}