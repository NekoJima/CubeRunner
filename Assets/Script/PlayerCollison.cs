using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerMovement Hitmove; // A reference to our Playermovement script

    // this function runs when we hit an objects
    // we get information about the collision by the variable named collisioninfor
    
    void OnCollisionEnter(Collision collisioninfor)
    {
        //Checking the collison with a tag named obstacle
        if (collisioninfor.collider.tag=="Obstacle")
        {
            // disable movement
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManagement>().GameOver();
        }
    }
}
