using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    private AnimationController animationController;
    private GameplayController gameplayController;

    private string playersChoice;

    void Awake() {
        animationController = GetComponent<AnimationController>();
        gameplayController = GetComponent<GameplayController>();
    }

    public void GetChoice() {

        string choiceName = UnityEngine.EventSystems.
            EventSystem.current.currentSelectedGameObject.name;

        GamesChoices selectedChoice = GamesChoices.NONE;

        switch(choiceName) {

            case "Rock":
                selectedChoice = GamesChoices.ROCK;
                break;

            case "Paper":
                selectedChoice = GamesChoices.PAPER;
                break;

            case "Scissors":
                selectedChoice = GamesChoices.SCISSORS;
                break;

        }

        gameplayController.SetChoices(selectedChoice);
        animationController.PlayerMadeChoice();

    }



} // class








































