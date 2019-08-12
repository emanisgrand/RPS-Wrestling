using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grapple : MonoBehaviour
{
    TestControls controls;

    private Animator        m_Animator;
    private Opponent        opponent;

    void Awake() {
        //  Set up controller inputs
        controls = new TestControls();
        controls.Gameplay.Grapple.performed += ctx => DoGrapple();
        controls.Gameplay.Grapple.canceled += ctx => StopGrappling();
        
        m_Animator = GetComponent<Animator>();  
        if (opponent == null) {
        opponent = GameObject.FindGameObjectWithTag("Opponent").GetComponent<Opponent>();
        
        }
    }

    void DoGrapple() {
        m_Animator.SetBool("grappleAttempt", true);
    }
    void StopGrappling() {
        m_Animator.SetBool("grappleAttempt", false);
    }

    protected void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {  
            m_Animator.SetBool("grappleAttempt", true);
        } 
        if (Input.GetKeyUp(KeyCode.Space)){
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
    // here the controls are enabled
    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

}
