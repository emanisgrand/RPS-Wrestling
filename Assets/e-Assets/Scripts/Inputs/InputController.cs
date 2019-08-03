using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    private AnimationController animationController;
    private GameplayController gameplayController;

    // Opponent references
    private GameObject opponent;
    private Opponent opponentScript;

    private string playersChoice;

    void Awake() {
        animationController = gameObject.GetComponent<AnimationController>();
        gameplayController = gameObject.GetComponent<GameplayController>();
        opponent = GameObject.FindGameObjectWithTag("Opponent");
        opponentScript = opponent.GetComponent<Opponent>();
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

        gameplayController.SetChoices(selectedChoice);
        animationController.PlayerMadeChoice();

    }



} // class








































