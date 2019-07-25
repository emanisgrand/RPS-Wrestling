using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    [SerializeField] private float health = 3f;

    public void TakeDamage(float damageAmount){
        health -= damageAmount;

        if (health <= 0) {
            OpponentLoses();
        }
    }

    void OpponentLoses(){
        // Player can do a pin animation
        // Opponent is counted out
        print("Opponent has lost the match");

    }
}
