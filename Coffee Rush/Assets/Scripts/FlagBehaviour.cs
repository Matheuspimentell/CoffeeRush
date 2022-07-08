using UnityEngine;

public class FlagBehaviour : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the player has collided with the flag and the has collected the coffee bean in this level, do some stuff
        if(collision.name == "Player" && player.coffeeBeans > 0)
        {
            Debug.Log("The player has passed this level!");
        }
    }
}
