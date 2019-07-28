//TODO: Figure out a way to have all of this work in the main gameObject

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this script needs to change to specifically be a Grab() script.
public class R_handTrigger : AbstractBehavior
{
    // Opponent's components =^P
    private Opponent    opponent;
    private Rigidbody   oppBody;
    private Collider    oppCollider;
    [SerializeField] private Transform   playerTransform;

    // Private member variables
    [SerializeField] 
    private Transform   grappleZone;
    private Vector3     originalCenter;   //! Useless vector3 at the moment

    // Public member variables
    public bool isGrappled;

    // Access the Opponent's animator 
    private Animator    oppAnim;

    protected override void Awake()
    {
        base.Awake();
      
        // playerTransform = gameObject.GetComponent<Transform>();
        opponent        = opponent.gameObject.GetComponent<Opponent>();  //? calling the opponent script?
        oppBody         = opponent.gameObject.GetComponent<Rigidbody>(); //? calling the Rigidbody that the opponent script is attached to, I hope.
        oppCollider     = opponent.gameObject.GetComponent<CapsuleCollider>(); //? Callng the collider that the opponent script is attached to, again, I hope.

    }

    private void OnTriggerEnter(Collider other)
    {
        oppAnim = other.gameObject.GetComponent<Animator>();
        if (other.gameObject.tag == "Opponent" && isGrappled == false)
        {
            isGrappled = true;
            other.transform.LookAt(playerTransform);
            other.transform.parent = grappleZone;
            
            //* 1. Disable the opponents ability to move so fucking much
            oppBody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
            // other.transform.position = grappleZone.position;
            
            //* 2. trigger animation
            //? Set the oppAnimator functionality */
            //enemyAnim.SetBool("Grappled", true);
            //ToggleScripts(false);
        }
    }

    private void Update() {
        if (oppCollider.transform.parent == grappleZone){
            isGrappled = true;
            print("isGrappled = true");
        } 
    }


}