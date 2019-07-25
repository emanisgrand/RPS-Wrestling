using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    // private serialized fields
    [SerializeField] private    float       reach     = 5f;
    [SerializeField] private    float       winDamage = 1f;
    
    // private member variables
    private                     RaycastHit  hit;
    private                     Opponent    opponent;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {  //considering fine tuning options here with GetKeyUp */
            // make the ray come out of the hand. 
            // OR, even better
            //TODO: Trigger an animation, and change this logic to collision detection to see
            // if the collider from the animation is hitting the opponent. 
            Debug.DrawRay(transform.position, transform.forward * reach, Color.yellow);
            Grab();
        }
    }

    void Grab(){
        //TODO: implement a layer mask for turnbuckle interaction
        if (Physics.Raycast(transform.position, transform.forward, out hit, reach)){

        if (hit.collider.tag == "Opponent") {
               opponent = hit.collider.gameObject.GetComponent<Opponent>();
               opponent.TakeDamage(winDamage);
            }    
        }
    }
}
