using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController2D controller; //Reference to the character controller
    private float h_movement = 0f; //Variable to keep track of the horizontal movement
    private bool isJumping = false; //Variable to keep track if a player is jumping
    public float speed = 30f; //Speed of the player
    public int coffeeBeans = 0; //Amount of Coffee Beans that the player has caught
    
    void Update()
    {
        //Every frame, get input from the player
        h_movement = Input.GetAxisRaw("Horizontal") * speed;

        //If the player pressed the Jump Button..
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        //Make the player move if the input is > 0 and < 1 || > -1 and < 0
        controller.Move(h_movement * Time.fixedDeltaTime, false, isJumping);
        isJumping = false;
    }
}
