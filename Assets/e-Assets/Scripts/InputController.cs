using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    private AnimationController animationController;
    private GameplayController gameplayController;

    private string playersChoice;

    void Awake() {
        animationController = gameObject.GetComponent<AnimationController>();
        gameplayController = gameObject.GetComponent<GameplayController>();
    }

    public void GetChoice() {

        string choiceName = UnityEngine.EventSystems.
            EventSystem.current.currentSelectedGameObject.name;

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








































