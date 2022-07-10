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
			//If the player falls on spikes...
			case "Spikes":

				manager.Play("death"); //Tocar o efeito sonoro de morte
				Destroy(player); //Destruir o Game Object do jogador
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Recarregar o nivel
				break;

			//If the player catches a coffee bean...
			case "Coffee Beans":
				
				p.coffeeBeans++; //Aumentar a quantidade de graos de cafe com o jogador
				manager.Play("coffeePickup"); //Tocar o efeito sonoro de pegar um grao de cafe
				Destroy(collision.gameObject); //Destruir o Game Object do grao de cafe
				break;

			//If the player reaches the flag...
			case "Flag":

				//If the player has collected this levels coffee bean
				if(p.coffeeBeans >= 1)
                {
					manager.Play("passedLevel"); //Play passed level sound effect
					p.coffeeBeans = 0; //Reset the coffee bean amount
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Load the next level
                }
				break;

			//If the player has fallen on water
			case "Water":
                
				manager.Play("death"); //Play the death sound effect
                Destroy(player); //Destroy the player game object
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Reload level
				break;

			default:
				
				//If the player collides with an unidentified object
				Debug.Log("Unidentified Object!!");
				break;
		}

	}
}
