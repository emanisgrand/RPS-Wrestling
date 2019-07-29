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
    private Animator    oppAnim;
    [SerializeField] private Transform   playerTransform;

    // Private member variables
    [SerializeField] 
    private Transform   grappleZone;

    // Public member variables
    public bool isGrappled;

    protected override void Awake()
    {
        base.Awake();
      
        // playerTransform = gameObject.GetComponent<Transform>();
        opponent        = opponent.gameObject.GetComponent<Opponent>();         //? calling the opponent script?
        oppBody         = opponent.gameObject.GetComponent<Rigidbody>();        //? calling the Rigidbody that the opponent script is attached to, I hope.
        oppCollider     = opponent.gameObject.GetComponent<CapsuleCollider>();  //? Callng the collider that the opponent script is attached to, again, I hope.

    }

    private void OnTriggerEnter(Collider other)
    {
        oppAnim = other.GetComponent<Animator>();
        
        if (other.gameObject.tag == "Opponent")
        {
            //! oppAnim.SetBool("isGrappled", true);
            //! isGrappled = true;

            other.transform.LookAt(playerTransform);
            other.transform.parent = grappleZone;
            
            //* 1. Disable the opponents ability to move so fucking much
            //! oppBody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        }
    }

    private void Update() {
        if (oppCollider.transform.parent == grappleZone){
            isGrappled = true;
            print("isGrappled = true");
        }

        if(isGrappled == true){
            //playerRigidibody.constraints = RigidbodyConstraints.FreezePositionZ 
        }

    }


}