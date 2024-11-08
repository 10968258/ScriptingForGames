
 using UnityEngine;

 public class PlayerMovement : MonoBehaviour
 {
     public float movespeed = 5f;
     public float jumpForce = 8f;
     public float gravity = -9.81f;
     private CharacterController controller;
     private Transform thisTransform;
     private Vector3 movementVector = Vector3.zero;
     private Vector3 velocity;

     private void Start()
     {
         controller = GetComponent<CharacterController>();
         thisTransform = transform;
     }

     private void Update()

     {
         MoveCharacter();
         ApplyGravity();
         KeepCharacterOnXAxis();
         if (Input.GetButtonDown("Jump") && controller.isGrounded)
         {
             velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
         }
     }

     private void MoveCharacter()
     {

         movementVector.x = Input.GetAxis("Horizontal");
         movementVector *= (movespeed * Time.deltaTime);
         controller.Move(movementVector);
     }
     private void ApplyGravity()
     {
         // Apply gravity when not grounded
         if (!controller.isGrounded)
         {
             velocity.y += gravity * Time.deltaTime;
         }
         else
         {
             velocity.y = 0f; // Reset velocity when grounded
         }

         // Apply the velocity to the controller
         controller.Move(velocity * Time.deltaTime);
     }

     private void KeepCharacterOnXAxis()
     {  
         
         Vector3 currentPosition = transform.position; // Assuming this is in a MonoBehaviour
         currentPosition.z = 0f;
         transform.position = currentPosition;

     }
 }