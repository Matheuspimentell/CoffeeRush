using UnityEngine;

public class CoffeeBeanPickup : MonoBehaviour
{
    public Player player;
    //If something collides with the coffee Bean...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the player is the object that has collided with the coffee bean...
        if(collision.name == "Player")
        {
            //Give the player +1 coffee bean and destroy the coffee bean
            player.coffeeBeans++;
            Destroy(this.gameObject);
        }
    }
}
