using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameChoices {   
    // * I was thinking something like this, but more for the outcomes than the choices themselves. I will have to try it this way though since it's basically done here.
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}

public class GameplayController : MonoBehaviour {

    [SerializeField]  //? none of the sprite image member variables will be necessary unless 
    //? I decide to implement some UI thing with them later. Which I am actually thinking 
    //? about doing. Something like the Mix&Jam Persona 4 
    //? cutscenes where they make a really big deal about the choice you end up making is 
    //? actually quite perfect. 
     
    private Sprite rock_Sprite, paper_Sprite, scissors_Sprite;

    [SerializeField]
    private Image playerChoice_Img, opponentChoice_Img;

    [SerializeField]
    private Text infoText;

    private GameChoices player_Choice = GameChoices.NONE, opponent_Choice = GameChoices.NONE;

    private AnimationController animationController;

    void Awake() {
        animationController = GetComponent<AnimationController>();
    }

    //* Idk, but maybe this is where choices are set. */
    public void SetChoices(GameChoices gameChoices) { 
    
        switch(gameChoices) {

            case GameChoices.ROCK:

            /* //! In this case, an image is switched out to represent the player's
            ! choice.  */
                playerChoice_Img.sprite = rock_Sprite;

                player_Choice = GameChoices.ROCK;

                break;

            case GameChoices.PAPER:

                playerChoice_Img.sprite = paper_Sprite;

                player_Choice = GameChoices.PAPER;

                break;

            case GameChoices.SCISSORS:

                playerChoice_Img.sprite = scissors_Sprite;

                player_Choice = GameChoices.SCISSORS;

                break;

        } // switch / case

        SetOpponentChoice();

        DetermineWinner();

    }

    void SetOpponentChoice() {

        int rnd = Random.Range(0, 3);
        //! switch cases used AGAIN! Except here there is not an enums array and instead
        //! choices are created in the method itself and defined in the switcher.

        switch(rnd) {

            case 0:
            //? is this redundant? No. Because this is opponent choice and so is separate from
            //? player choice so it must be distinct, right? 

                opponent_Choice = GameChoices.ROCK;

                opponentChoice_Img.sprite = rock_Sprite;

                break;

            case 1:

                opponent_Choice = GameChoices.PAPER;

                opponentChoice_Img.sprite = paper_Sprite;

                break;

            case 2:

                opponent_Choice = GameChoices.SCISSORS;

                opponentChoice_Img.sprite = scissors_Sprite;

                break;

        }



    }

    void DetermineWinner() { 
        //! here is the actual Decision tree, right? 

        if(player_Choice == opponent_Choice) {
            // draw

            infoText.text = "It's a Draw!";
            StartCoroutine(DisplayWinnerAndRestart());  //! This "DisplayWinnerAndRestart()" function is
                                                        //! I think, where I would be executing the 
                                                        //! animations.
            return;

        }

        if(player_Choice == GameChoices.PAPER && opponent_Choice == GameChoices.ROCK) {
            // player won

            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_Choice == GameChoices.PAPER && player_Choice == GameChoices.ROCK) {
            // opponent won

            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (player_Choice == GameChoices.ROCK && opponent_Choice == GameChoices.SCISSORS) {
            // player won

            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_Choice == GameChoices.ROCK && player_Choice == GameChoices.SCISSORS) {
            // opponent won

            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (player_Choice == GameChoices.SCISSORS && opponent_Choice == GameChoices.PAPER) {
            // player won

            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_Choice == GameChoices.SCISSORS && player_Choice == GameChoices.PAPER) {
            // opponent won

            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

    }

    //! If I want to make this guy wait, then I need to use IEnumerator. 
    IEnumerator DisplayWinnerAndRestart() {
        yield return new WaitForSeconds(2f);

        infoText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        infoText.gameObject.SetActive(false);
        //? My animations will be way more complicated and varied than this.
        //? It would be nice to have an array of animations to sift through 
        animationController.ResetAnimations();

    }

} // class

































