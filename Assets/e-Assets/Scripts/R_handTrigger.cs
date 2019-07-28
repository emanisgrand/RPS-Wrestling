using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this script needs to change to specifically be a Grab() script.
public class R_handTrigger : AbstractBehavior
{
    //public float grappleSpotOffset = 2f;
    [SerializeField] private Transform grappleZone;
    
    // Opponent's components =^P
    private Opponent opponent;
    private Rigidbody oppBody;
    private bool isGrappled;

    //! Useless vector3
    private Vector3 originalCenter;

    // Access the Opponent's animator 
    private Animator oppAnim;

    protected override void Awake()
    {
        base.Awake();
        //? so...I could attach this empty transform to the hand trigger, but
        //? that would be a little or a lot bit messy. It would be better to 
        //? detach this part of the script that handles the grappleZone from the
        //? hand and move everything to the main Parent gameObject so that everything
        //? is more properly centered. I will try this out for now though juts to see.

        oppBody = opponent.GetComponent<Rigidbody>();

    }

    private void OnTriggerEnter(Collider other)
    {
        oppAnim = other.gameObject.GetComponent<Animator>();
        if (other.gameObject.tag == "Opponent")
        {
            other.transform.parent = grappleZone;
            oppBody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
            // other.transform.position = grappleZone.position;
            // 1. Disable the opponents ability to move so fucking much
            // Create an instance of the player transform script. Disable it.
            // 2. trigger animation
            //* Set the oppAnimator functionality */
            //enemyAnim.SetBool("Grappled", true);
            //ToggleScripts(false);
        }
    }

    private void Update() {
        if (oppBody.transform.parent = grappleZone){
            isGrappled = true;
            print("isGrappled = true");
        }
    }


}