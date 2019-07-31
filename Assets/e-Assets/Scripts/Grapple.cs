using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{   
    private Animator        m_Animator;
    private Opponent        opponent;

    void Start() {
        m_Animator = GetComponent<Animator>();  
        if (opponent == null) {
        opponent = GameObject.FindGameObjectWithTag("Opponent").GetComponent<Opponent>();
        }
    }

    protected void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {  
            m_Animator.SetBool("grappleAttempt", true);
        } 
        if (Input.GetKeyUp(KeyCode.Space)){
            //! This is very waasteful. Adjust this
            m_Animator.SetBool("grappleAttempt", false);
        }

        if (opponent.isGrappled == true) {
            m_Animator.SetBool("Grappling", true);
        } else
        {
            //! Adjust this logic so it doesn't have to be calling on Update
            m_Animator.SetBool("Grappling", false);
        }

    } 
}
