using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    [SerializeField] private float health = 3f;
    public GameObject   oppGameObject; 
    public Collider     oppCollider;
    public Rigidbody    oppBody;

    private void Awake() {
        oppGameObject   = this.gameObject;
        oppCollider     = oppGameObject.GetComponent<Collider>();
        oppBody         = oppGameObject.GetComponent<Rigidbody>();
    }

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
