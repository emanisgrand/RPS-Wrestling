﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    //! This code isn't doing anything right now.
    
    [SerializeField] private Collider handCollider;  //! set the Hand collider to pass into OnTriggerEnter
    [SerializeField] private Transform grappleZone;  //! here's an empty transform to center the opponents
    
    // private member variables
    private Animator        m_Animator;
    private Animator        enemyAnim;
    private Opponent        opponent;
    // a trigger to enable the collider
    private bool            isGrappling;
    
    // the initial trigger I set up to parent the GO 
    private bool            grappleAttempt;

    //call an instance of the R_handTrigger script
    private R_handTrigger   _handTrigger;

    void Start() {
        
        m_Animator = GetComponent<Animator>();    
        
        if (enemyAnim != null) {
            enemyAnim = opponent.gameObject.GetComponent<Animator>();
        }
        
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
            print("Space Up");
            m_Animator.SetBool("grappleAttempt", false);
            _handTrigger.isGrappled = false;
        }
    } 
}
