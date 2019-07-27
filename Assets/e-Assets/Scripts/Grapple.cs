using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    // private serialized fields
    // [SerializeField] private    float       reach     = 5f;
    // [SerializeField] private    float       winDamage = 1f;
    
    
    [SerializeField] private Collider handCollider;  //! set the Hand collider to pass into OnTriggerEnter
    [SerializeField] private Transform grappleZone;  //! here's an empty transform to center the opponents
    
    // private member variables
    private                     Animator    m_Animator;
    private                     Animator    enemyAnim;
    private                     Opponent    opponent;
    private                     bool        grappleAttempt;

    void Start() {
        m_Animator = GetComponent<Animator>();    
        enemyAnim = opponent.gameObject.GetComponent<Animator>();
        handCollider = GetComponent<Collider>();
        //handCollider = GetComponent<Collider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {  //considering fine tuning options here with GetKeyUp */
            // make the ray come out of the hand. 
            // OR, even better
            m_Animator.SetBool("grappleAttempt", true);
            // and later change this logic to collision detection to see
            // if the collider from the animation is hitting the opponent. 
        } 
        if (Input.GetKeyUp(KeyCode.Space)){
            m_Animator.SetBool("grappleAttempt", false);
        }
    }

    private void OnTriggerEnter(Collider handCollider) //? not sure if this handcollider is the right parameter to get the job done
    {    
        if (handCollider.gameObject.tag == "Opponent")
        {
            print("bopped " + handCollider.name);
            opponent.gameObject.transform.parent = grappleZone;
            // 1. Disable the opponents ability to move so fucking much
            // Create an instance of the player transform script. Disable it.
            // 2. trigger animation

            enemyAnim.SetBool("Grappled", true);
            //ToggleScripts(false);
        }
    }
}
