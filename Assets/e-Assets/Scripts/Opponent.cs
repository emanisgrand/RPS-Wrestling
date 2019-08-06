using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Opponent : MonoBehaviour
{
    private GameObject  playerGoOpp;
    
    
    // Public member variables that I don't think need to be public
    public string       targetTag       = "HandTrigger";
    public GameObject   oppGameObject;    
    public Collider     oppCollider; 
    public Rigidbody    oppBody;        // used in the constraints
    public bool         isGrappled;     // big trigger which will be widely used.
    public float        health;
    public bool         oppLost;

    // Private member variables
    [SerializeField]
    private Transform       grappleZone;
    [SerializeField]
    private Transform       playerTransform;
    //Oppoenent Animator
    private Animator        oppAnim;


    private void Awake() {
        playerGoOpp     = GameObject.FindGameObjectWithTag("Player");
        oppAnim         = GetComponent<Animator>();
        oppGameObject   = this.gameObject;
        oppCollider     = oppGameObject.GetComponent<Collider>();
        oppBody         = oppGameObject.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider target) {
        if (target.gameObject.tag == targetTag) {
            oppAnim.SetBool("isGrappled", true);
            isGrappled = true;

            //* Move this to its own method */
            //? sets player transform as the parentObj
            oppCollider.transform.parent = grappleZone;
            //? constraints test
            oppBody.constraints =   RigidbodyConstraints.FreezePositionZ | 
                                    RigidbodyConstraints.FreezeRotationZ | 
                                    RigidbodyConstraints.FreezeRotationY;
            //? turn and look at the grappler  
            oppCollider.transform.LookAt(playerTransform);           
        }
    }
    
    //TODO: Unused logic here.See if there's anything useful
    /*
    if (isGrappled == true) {
        * playerBody.constraints = RigidbodyConstraints.FreezePositionX,Y,Z ?
        
        
        * EngageRPS();
    }
     */
    //* Called when Taking Damage
    public void TakeDamage(float damageAmount){
        health -= damageAmount;
        if (health <= 0) {
            OpponentLoses();
            oppLost = false;
        } 
    }

    void OpponentLoses(){
        // Player does a pin animation
        // Opponent is counted out
        oppLost = true;
    } 
}
