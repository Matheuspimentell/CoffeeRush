using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{

    public float waitTimer = 1.0f;
    private float waitingTime;
    private bool isJumping = false;
    private PlatformEffector2D effector;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
        waitingTime = waitTimer;
    }

    void Update()
    {
        if(Input.GetKeyUp("down") && Input.GetKeyUp("s"))
        {
            waitingTime = waitTimer;
        }

        if(Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
            if(waitingTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitingTime = waitTimer;
            }
        }
        else
        {
            waitingTime -= Time.fixedDeltaTime;
        }

        isJumping = Input.GetButtonDown("Jump");
        if (isJumping)
        {
            effector.rotationalOffset = 0f;
            isJumping = false;
        }
    }
}
