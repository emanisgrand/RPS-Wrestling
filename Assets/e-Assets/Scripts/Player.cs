using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : AbstractBehavior
{
    public  float health;
    public GameObject gameOverUI;

    private bool canPlay = true;

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            canPlay = false;
        }
    }

    // protected virtual void PlayerLost(bool value){
    //     gameOverUI.SetActive(true);
    //     print("PlayerLost bool activated");
    //     ToggleScripts(false);
    // }



}
