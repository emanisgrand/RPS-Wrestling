using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Opponent : MonoBehaviour
{
    private GameObject  playerGoOpp;
    
    
    // Public member variables that I don't think need to be public
    public string       targetTag = "HandTrigger";
    public GameObject   oppGameObject;    //? what do I need this GO for?
    public Collider     oppCollider;      //? can I just use this collider?
    public Rigidbody    oppBody;          //? I know I need this
    public bool         isGrappled;       //? big trigger

    // Private member variables
    [SerializeField] 
    private float       health = 3f;
    [SerializeField]
    private Transform   grappleZone;
    [SerializeField]
    private Transform playerTransform;
    //Oppoenent Animator
    private Animator    oppAnim;
    


    private void Awake() {
        playerGoOpp       = GameObject.FindGameObjectWithTag("Player");
        oppAnim         = GetComponent<Animator>();
        oppGameObject   = this.gameObject;
        oppCollider     = oppGameObject.GetComponent<Collider>();
        oppBody         = oppGameObject.GetComponent<Rigidbody>();

    }

    private void OnTriggerEnter(Collider target) {
        if (target.gameObject.tag == targetTag) {
            print("triggered");
            oppAnim.SetBool("isGrappled", true);
            isGrappled = true;

            //* Move this to its own method */
            //? sets player transform as the parentObj
            oppCollider.transform.parent = playerGoOpp.transform;
            
            //? constraints test
            oppBody.constraints =   RigidbodyConstraints.FreezePositionZ | 
                                    RigidbodyConstraints.FreezeRotationZ | 
                                    RigidbodyConstraints.FreezeRotationY;
            
            //? turn and look at the grappler  
            oppCollider.transform.LookAt(playerTransform);           
        }
    }

    /*
    if (isGrappled == true) {
        oppCollider.transform.LookAt(//?playerTransform);
        oppAnim.SetBool("isGrappled", true);
        playerBody.constraints = RigidbodyConstraints....
        oppBody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        
        * EngageRPS();
    }
     */

    public void TakeDamage(float damageAmount){
        health -= damageAmount;

        if (health <= 0) {
            OpponentLoses();
        } 
    }

    //TODO: Find the example bool method from previous project.
    //* There was a method that was basically a boolean and had a bunch of actions
    //* in it that were beings called when the bool was true. Find it. */

    void OpponentLoses(){
        // Player can do a pin animation
        // Opponent is counted out
        print("Opponent has lost the match");

    } 
}
