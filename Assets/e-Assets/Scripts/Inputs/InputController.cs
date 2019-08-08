using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour {
    TestControls controls;

    private AnimationController animationController;
    private GameplayController gameplayController;

    // Opponent references
    private GameObject opponent;
    private Opponent opponentScript;
    
    //? The game enabler
    [SerializeField]
    private bool canPlay;
    private string playersChoice;

    void Awake() {
        controls = new TestControls();
        controls.Gameplay.Rock.performed += ctx => Rock();
        controls.Gameplay.Paper.performed += ctx => Paper();
        controls.Gameplay.Scissor.performed += ctx => Scissor();

        animationController = gameObject.GetComponent<AnimationController>();
        gameplayController = gameObject.GetComponent<GameplayController>();
        opponent = GameObject.FindGameObjectWithTag("Opponent");
        opponentScript = opponent.GetComponent<Opponent>();
        canPlay = true;
    }

    protected virtual void Update(){
        
        if(Input.GetKeyDown(KeyCode.R) && opponentScript.isGrappled == true) {
            GetChoice("Rock");
        }
        if (Input.GetKeyDown(KeyCode.F) && opponentScript.isGrappled == true) {
            GetChoice("Paper");
        }
        if (Input.GetKeyDown(KeyCode.C) && opponentScript.isGrappled == true) {
            GetChoice("Scissors");
        }
    }

    void Rock(){
        if (opponentScript.isGrappled == true) {
            GetChoice("Rock");
        }
    }
    void Paper(){
        if (opponentScript.isGrappled == true){
            GetChoice("Paper");
        }
    }
    void Scissor(){
        if (opponentScript.isGrappled == true) {
            GetChoice("Scissors");
        }
    }

    public void GetChoice(string choiceName) {

        // string choiceName = UnityEngine.EventSystems.
        //     EventSystem.current.currentSelectedGameObject.name;

        GamesChoices selectedChoice = GamesChoices.NONE;

        switch(choiceName) {

            case "Rock":
                selectedChoice = GamesChoices.ROCK;
                print("player selected " + selectedChoice);
                break;

            case "Paper":
                selectedChoice = GamesChoices.PAPER;
                print("player selected " + selectedChoice);
                break;

            case "Scissors":
                selectedChoice = GamesChoices.SCISSORS;
                print("player selected " + selectedChoice);
                break;

        }

        if (canPlay == true){
        gameplayController.SetChoices(selectedChoice);
        }

        animationController.PlayerMadeChoice();
    }

    private void OnEnable()
        {
            controls.Gameplay.Enable();
        }

        private void OnDisable()
        {
            controls.Gameplay.Disable();
        }


} // class








































