using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Buttons {
    B_ROCK,
    B_PAPER,
    B_SCISSOR
}

public enum Condition{           // This is what will hold all the Conditions. Similar to how Mecanim handles transitions
    GreaterThan,
    LessThan
}

// 👀 We are going to keep a public array of Input Axis' as States. 
[System.Serializable]
public class InputAxisState {
    public string axisName;      // The actual name of the Axis. 
    public float offValue;       // We know axis states return to 0 when they're off so this is a float value.
    public Buttons button;       // the enums.  
    public Condition condition;  // A reference to our enum which will now be referred to as condition.

    public bool value{           // here we declare the boolean and call it value.
        get{                     // I believe this is how we start using switch conditions, we start with get
            var val = Input.GetAxis(axisName);   

            switch(condition){                       //and continue on to use switch. We delcared Condition up top, but could also be used here as the class itself
                case Condition.GreaterThan:          //We're saying 'GET' our CONDITION that we've called GREATERTHAN, consider it a CASE -  
                return val > offValue;               //and make it true when the input axis value is more than its off value.
                case Condition.LessThan:    
                return val < offValue;
            }
            return false;       // Something must be returned and since this is a bool, we return false;
        }
    }
}

public class InputManager : MonoBehaviour
{
    public InputAxisState[] inputs;  //👀 The input axis state array that I mentioned earlier
    public InputState inputState;    // 🔣 This is a reference to the Game Object the inputstate class is attached to.  

    void Update()
    {
        foreach (var input in inputs){
            inputState.SetButtonValue(input.button, input.value); // loop through the inputs in value and abstract which button is being pressed.
        
        }
    }

}


