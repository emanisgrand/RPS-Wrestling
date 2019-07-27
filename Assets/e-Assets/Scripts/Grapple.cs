using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    // private serialized fields
    [SerializeField] private    float       reach     = 5f;
    [SerializeField] private    float       winDamage = 1f;
    
    // private member variables
    private                     Animator    m_Animator;
    //! private  deprecate      RaycastHit  hit;   
    private                     Opponent    opponent;
    private                     bool        grappleAttempt;

    void Start() {
        m_Animator = GetComponent<Animator>();    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {  //considering fine tuning options here with GetKeyUp */
            // make the ray come out of the hand. 
            // OR, even better
            m_Animator.SetBool("grappleAttempt", true);
            // and later change this logic to collision detection to see
            // if the collider from the animation is hitting the opponent. 
            Grab();
        } 
        if (Input.GetKeyUp(KeyCode.Space)){
            m_Animator.SetBool("grappleAttempt", false);
        }
    }

    void Grab(){
        //TODO: replace the raycast with hand triggers instead 

        

        //! if (Physics.Raycast(transform.position, transform.forward, out hit, reach)){

        //!    if (hit.collider.tag == "Opponent") {
        //!        opponent = hit.collider.gameObject.GetComponent<Opponent>();
        //!        opponent.TakeDamage(winDamage);
        //!        }    
        //!    }
    }
}
