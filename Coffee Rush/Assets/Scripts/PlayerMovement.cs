using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller; //Reference to the character controller
    private float h_movement = 0f; //Variable to keep track of the horizontal movement
    private bool isJumping = false;
    public float speed = 30f; //Speed of the player
    
    void Update()
    {
        //Every frame, get input from the player
        h_movement = Input.GetAxisRaw("Horizontal") * speed;
        isJumping = Input.GetButtonDown("Jump");

    }

    private void FixedUpdate()
    {
        //Make the player move if the input is > 0 and < 1 || > -1 and < 0
        controller.Move(h_movement * Time.fixedDeltaTime, false, isJumping);
    }
}
