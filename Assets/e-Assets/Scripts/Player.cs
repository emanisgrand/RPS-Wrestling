using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public  float health;

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        print("Player has taken " + damageAmount + " damage.");
        if (health <= 0)
        {
            PlayerLoses();
        }
    }

    public void PlayerLoses(){
        print("Player has lost");
        //TODO: need a way to reset the match. 
    }
}
