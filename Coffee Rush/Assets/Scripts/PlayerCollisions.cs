using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
	public AudioManager manager;
	public GameObject player;
	private Player p;

	private void Awake()
	{
		p = player.GetComponent<Player>();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		switch (collision.name)
		{
			case "Spikes":
				manager.Play("death");
				Destroy(player);
				break;
			case "Coffee Beans":
				p.coffeeBeans++;
				manager.Play("coffeePickup");
				Destroy(collision.gameObject); //Destroys the coffee bean game object
				break;
			case "Flag":
				manager.Play("passedLevel");
				Debug.Log("The player has reached the flag!");
				break;
			default:
				Debug.Log("Unidentified Object!!");
				break;
		}

	}
}
