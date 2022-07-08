using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagBehaviour : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player" && player.coffeeBeans > 0)
        {
            Debug.Log("The player has passed this level!");
        }
    }
}
