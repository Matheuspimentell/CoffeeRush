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
				Destroy(player);
				Debug.Log("The player has fallen on spikes");
				break;
			case "Coffee Beans":
				p.coffeeBeans++;
				Debug.Log(p.coffeeBeans);
				Destroy(collision.gameObject); //Destroys the coffee bean game object
				break;
			case "Flag":
				Debug.Log("The player has reached the flag!");
				break;
			default:
				Debug.Log("Unidentified Object!!");
				break;
		}

	}
}
