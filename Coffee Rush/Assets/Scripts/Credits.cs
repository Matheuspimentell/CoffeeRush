using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{ 
    // Quit the game when the player presses 'esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("The player has finished the game.");
            Application.Quit();
        }

    }
}
