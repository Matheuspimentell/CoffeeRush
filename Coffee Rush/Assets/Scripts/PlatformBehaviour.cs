using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{

    public float waitTimer = 1.0f; //Wait timer for the player to be able to jump down
    private float waitingTime; //The current waiting time
    private bool hasJumped = false; //Whether or not a player has jumped
    private PlatformEffector2D effector; //reference to the platform effector on all platforms

    void Start()
    {
        //Grab the refence to the platform effector and set the waiting time to the determined wait timer
        effector = GetComponent<PlatformEffector2D>();
        waitingTime = waitTimer;
    }

    void FixedUpdate()
    {
        //If the player isn't jumping...
        if(Input.GetKeyUp("down") && Input.GetKeyUp("s"))
        {
            //Set the waiting time to the determined wait timer
            waitingTime = waitTimer;
        }

        //If the player presses a key to get down from the platform...
        if(Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
            //If the current waiting time is equal or lower to 0...
            if(waitingTime <= 0)
            {
                //Flip the rotational offset on the effector ans reset the waiting time
                effector.rotationalOffset = 180f;
                waitingTime = waitTimer;
            }
        }
        //if the player isn't jumpung...
        else
        {
            //Decrease the waiting time
            waitingTime -= Time.fixedDeltaTime;
        }

        //Keep track if the player has jumped
        hasJumped = Input.GetButtonDown("Jump");

        //If the player has jumped...
        if (hasJumped)
        {
            //Reset the effector rotational offset and reset the jumping tracker
            effector.rotationalOffset = 0f;
            hasJumped = false;
        }
    }
}
