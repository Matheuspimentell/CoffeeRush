using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
				break;

			case "Coffee Beans":
				
				p.coffeeBeans++;
				manager.Play("coffeePickup");
				Destroy(collision.gameObject);
				break;

			case "Flag":
				manager.Play("passedLevel");
				Debug.Log("The player has reached the flag!");
				if(p.coffeeBeans >= 1)
                {
					p.coffeeBeans = 0;
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
				break;

			case "Water":
                
				manager.Play("death");
                Destroy(player);
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
				break;

			default:
				
				Debug.Log("Unidentified Object!!");
				break;
		}

	}
}
