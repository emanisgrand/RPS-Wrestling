using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! There are way more declarations in here than there need to be

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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {  
            m_Animator.SetBool("grappleAttempt", true);
        } 
        if (Input.GetKeyUp(KeyCode.Space)){
            print("Space Up");
            m_Animator.SetBool("grappleAttempt", false);
        }

        if (opponent.isGrappled == true) {
            print("isgrappled is true");
            m_Animator.SetBool("Grappling", true);
        } else
        {
            print ("isgrappled = false");
            m_Animator.SetBool("Grappling", false);
        }

    } 
}
