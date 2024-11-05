
 using UnityEngine;

 public class PlayerMovement : MonoBehaviour
 {
     public float movespeed = 5f;
     private CharacterController controller;
     private Transform thisTransform;
     private Vector3 movementVector = Vector3.zero;

     private void Start()
     {
         controller = GetComponent<CharacterController>();
         thisTransform = transform;
     }

     private void Update()

     {
         MoveCharacter();
         KeepCharacterOnXAxis();
         
     }

     private void MoveCharacter()
     {

         movementVector.x = Input.GetAxis("Horizontal");
         movementVector *= (movespeed * Time.deltaTime);
         controller.Move(movementVector);
     }

     private void KeepCharacterOnXAxis()
     {  
         
         Vector3 currentPosition = transform.position; // Assuming this is in a MonoBehaviour
         currentPosition.z = 0f;
         transform.position = currentPosition;

     }
 }