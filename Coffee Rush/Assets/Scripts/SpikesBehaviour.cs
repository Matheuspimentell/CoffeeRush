using UnityEngine;

public class SpikesBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the spikes collide with the player, make some stuff...
        if(collision.name == "Player")
        {
            Debug.Log("THE PLAYER DIED! MWAHAHAHAHAHA");
            Destroy(collision.gameObject);
        }
    }
}
