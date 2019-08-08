using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cube : MonoBehaviour
{


    TestControls controls;

    // this is the value that the context reader will read.
    Vector2 move;
    Vector2 rotate;

    private void Awake() {
        controls = new TestControls();
        //? Lambda expression is used here. 
        //! 'ctx' is the stand in for "context" and seems to be defined inline
        // go into the Input Controller I created and add the context I called Grow to your perform command.
        controls.Gameplay.Run.performed += ctx => Run();

        // similar to Grow, here I am telling you to read my move variable, and add that to the Move action that I created.
        //TODO: test read value to see how it handles vector3s
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        // once your done reading Move, set the Vector2 value back to default (which is zero)
        controls.Gameplay.Move.canceled  += ctx => move = Vector2.zero; 

        controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.Gameplay.Rotate.canceled += ctx => rotate = Vector2.zero;
    }

    private void Update() {
        
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
        Vector2 r = new Vector2(rotate.x, rotate.y) * 100f * Time.deltaTime;
        
        // this handles the actual movement calculation when the inputs are given.
        transform.Translate(m, Space.World);
        transform.Rotate(r, Space.World);
    }

    void Run(){
        // this is the actual grow function used when Grow is set to perform. 
        transform.localScale *= 1.1f;
        
    }

    // here the controls are enabled
    private void OnEnable() {
        controls.Gameplay.Enable();    
    }

    private void OnDisable() {
        controls.Gameplay.Disable();
    }
}
