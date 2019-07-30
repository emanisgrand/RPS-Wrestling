using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GamesChoices {   
    // * I was thinking something like this, but more for the outcomes than the choices themselves. I will have to try it this way though since it's basically done here.
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}

public class GameplayController : MonoBehaviour {

    [SerializeField]       
    private Sprite rock_Sprite, paper_Sprite, scissors_Sprite;

    [SerializeField]
    private Image playerChoice_Img, opponentChoice_Img;

    [SerializeField]
    private Text infoText;

    private GamesChoices player_Choice = GamesChoices.NONE, opponent_Choice = GamesChoices.NONE;

    private AnimationController animationController;

    void Awake() {
        animationController = GetComponent<AnimationController>();
    }

    //* Idk, but maybe this is where choices are set. */
    public void SetChoices(GamesChoices gamesChoices) { 
    
        switch(gamesChoices) {

            case GamesChoices.ROCK:
            
                playerChoice_Img.sprite = rock_Sprite;
                
                player_Choice = GamesChoices.ROCK;

                break;

            case GamesChoices.PAPER:

                playerChoice_Img.sprite = paper_Sprite;
                print("player selected" + gamesChoices);
                player_Choice = GamesChoices.PAPER;

                break;

            case GamesChoices.SCISSORS:

                playerChoice_Img.sprite = scissors_Sprite;
                print("player selected" + gamesChoices);
                player_Choice = GamesChoices.SCISSORS;

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

                opponent_Choice = GamesChoices.ROCK;

                opponentChoice_Img.sprite = rock_Sprite;

                break;

            case 1:

                opponent_Choice = GamesChoices.PAPER;

                opponentChoice_Img.sprite = paper_Sprite;

                break;

            case 2:

                opponent_Choice = GamesChoices.SCISSORS;

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

        if(player_Choice == GamesChoices.PAPER && opponent_Choice == GamesChoices.ROCK) {
            // player won

            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_Choice == GamesChoices.PAPER && player_Choice == GamesChoices.ROCK) {
            // opponent won

            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (player_Choice == GamesChoices.ROCK && opponent_Choice == GamesChoices.SCISSORS) {
            // player won

            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_Choice == GamesChoices.ROCK && player_Choice == GamesChoices.SCISSORS) {
            // opponent won

            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (player_Choice == GamesChoices.SCISSORS && opponent_Choice == GamesChoices.PAPER) {
            // player won

            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_Choice == GamesChoices.SCISSORS && player_Choice == GamesChoices.PAPER) {
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

































