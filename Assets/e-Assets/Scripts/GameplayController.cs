using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum GamesChoices {   
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}

public class GameplayController : AbstractBehavior {

    //? we don't want our behaviors to actually know anything about other behaviors. 
    //? All we want them to know is that at some point they can loop through all the scripts that are associated with it, 
    //? and disable and enable them based on its own state 
    //? public Animation[] animations; 

    // Player & Opponent References
    private Animator            oppAnimator, playerAnimator;
    private GameObject          opponent;
    private Opponent            opponentScript;
    private GameObject          player;
    private Player              playerScript;
    private bool                canPlay;
    
    private GameObject          winnerDisplay;

    // Sprites & images
    [SerializeField]       
    private Sprite              rock_Sprite, paper_Sprite, scissors_Sprite;
    [SerializeField]
    private Image               playerChoice_Img, opponentChoice_Img;
    [SerializeField]
    private Text                infoText;

    // enums and anims
    private GamesChoices        player_Choice = GamesChoices.NONE, 
                                opponent_Choice = GamesChoices.NONE;
    private AnimationController animationController;

    void Start() {
        animationController = GetComponent<AnimationController>();
        opponent            = GameObject.FindGameObjectWithTag("Opponent");
        opponentScript      = opponent.GetComponent<Opponent>();
        player              = GameObject.FindGameObjectWithTag("Player");
        playerScript        = player.GetComponent<Player>();       
        
        canPlay             = true;
    }

    public void SetChoices(GamesChoices gamesChoices) { 
    
        switch(gamesChoices) {

            case GamesChoices.ROCK:
            
                playerChoice_Img.sprite = rock_Sprite;
                
                player_Choice = GamesChoices.ROCK;

                break;

            case GamesChoices.PAPER:

                playerChoice_Img.sprite = paper_Sprite;
                player_Choice = GamesChoices.PAPER;

                break;

            case GamesChoices.SCISSORS:

                playerChoice_Img.sprite = scissors_Sprite;
                player_Choice = GamesChoices.SCISSORS;

                break;

        } // switch / case

        SetOpponentChoice();

        DetermineWinner();
    }

    void SetOpponentChoice() {

        int rnd = Random.Range(0, 3);

        switch(rnd) {

            case 0:

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

        if(player_Choice == opponent_Choice) {
            // draw
            infoText.text = "It's a Draw!";
            Ungrapple();
            StartCoroutine(DisplayWinnerAndRestart());
            return;

        }

        if(player_Choice == GamesChoices.PAPER && opponent_Choice == GamesChoices.ROCK ||
            player_Choice == GamesChoices.ROCK && opponent_Choice == GamesChoices.SCISSORS ||
            player_Choice == GamesChoices.SCISSORS && opponent_Choice == GamesChoices.PAPER ) {
            // player won
            opponentScript.TakeDamage(1);
            ToggleScripts(false);
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            StartCoroutine(PlayerAttackAnim());
            return;
        }

        if (opponent_Choice == GamesChoices.PAPER && player_Choice == GamesChoices.ROCK ||
            opponent_Choice == GamesChoices.ROCK && player_Choice == GamesChoices.SCISSORS ||
            opponent_Choice == GamesChoices.SCISSORS && player_Choice == GamesChoices.PAPER ) {
            // opponent won
            playerScript.TakeDamage(1);
            ToggleScripts(false);
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            StartCoroutine(PlayerAttackAnim());
            return;
        }

        // if (player_Choice == GamesChoices.ROCK && opponent_Choice == GamesChoices.SCISSORS) {
        //     // player won
        //     opponentScript.TakeDamage(1);
        //     infoText.text = "You Win!";
        //     StartCoroutine(DisplayWinnerAndRestart());
        //     StartCoroutine(DoSomeAnimation());
        //     return;
        // }

        // if (opponent_Choice == GamesChoices.ROCK && player_Choice == GamesChoices.SCISSORS) {
        //     // opponent won
        //     playerScript.TakeDamage(1);
        //     infoText.text = "You Lose!";
        //     StartCoroutine(DisplayWinnerAndRestart());
        //     StartCoroutine(DoSomeAnimation());
        //     return;
        // }

        // if (player_Choice == GamesChoices.SCISSORS && opponent_Choice == GamesChoices.PAPER) {
        //     // player won
        //     opponentScript.TakeDamage(1);
        //     infoText.text = "You Win!";
        //     StartCoroutine(DisplayWinnerAndRestart());
        //     StartCoroutine(DoSomeAnimation());
        //     return;
        // }

        // if (opponent_Choice == GamesChoices.SCISSORS && player_Choice == GamesChoices.PAPER) {
        //     // opponent won
        //     playerScript.TakeDamage(1);;
        //     infoText.text = "You Lose!";
        //     StartCoroutine(DisplayWinnerAndRestart());
        //     StartCoroutine(DoSomeAnimation());
        //     return;
        // }
       
    }

    IEnumerator DisplayWinnerAndRestart() {
        yield return new WaitForSeconds(2f);

        infoText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        infoText.gameObject.SetActive(false);
     
        animationController.ResetAnimations();

    }

    void Ungrapple(){
        opponent.transform.parent = null;
        opponentScript.isGrappled = false;
        oppAnimator.SetBool("isGrappled", false);
    }

    IEnumerator PlayerAttackAnim() {                         //* take in an array of possible animations or animation triggers set by the choice that gets made */
       oppAnimator = opponent.GetComponent<Animator>();
       playerAnimator = player.GetComponent<Animator>();

        //* foreach (animation in animations[]) {  } */

       opponentScript.isGrappled    = false;
       //In Opponent.OnTriggerEnter, The Opponent's transform is parented to an empty game obj that is attached to the player. 
       //Here we unparent the Opponent's transform.
       opponent.transform.parent    = null;  
       oppAnimator.SetBool("isGrappled", false);
       playerAnimator.SetBool("test", true);
       oppAnimator.SetBool("test", true);
       yield return new WaitForSeconds(10f);  //*  use animation time */
       playerAnimator.SetBool("test", false);
       oppAnimator.SetBool("test", false);
    }

    IEnumerator OpponentAttackAnim()
    {                         //* take in an array of possible animations or animation triggers set by the choice that gets made */
        oppAnimator = opponent.GetComponent<Animator>();
        playerAnimator = player.GetComponent<Animator>();

        //* foreach (animation in animations[]) {  } */

        opponentScript.isGrappled = false;
        //In Opponent.OnTriggerEnter, The Opponent's transform is parented to an empty game obj that is attached to the player. 
        //Here we unparent the Opponent's transform.
        opponent.transform.parent = null;
        oppAnimator.SetBool("isGrappled", false);
        playerAnimator.SetBool("test", true);
        oppAnimator.SetBool("test", true);
        yield return new WaitForSeconds(10f);  //*  use animation time */
        playerAnimator.SetBool("test", false);
        oppAnimator.SetBool("test", false);
    }

    //TODO:👇Animation array logic 
    /*
        protected virtual void AnimationsThingy (bool value)  //? should it take a bool or some other kind of parameter
            {
            
                foreach (var animation in animationsArray)   //? I believe `var animation` sets the variable we're hoping to reference in the loop
                {                                            //? so either we store animations OR the animation triggers. Such as a separate variable
                    animation.setBool = value;               //? that contains all of the animation trigger names. 
                }                                            //! refer to AbstractBehavior / Duck.cs as an example for how value is being used here.
            }
    */

} 


//TODO: Create a match RESET where player health is set back to full and the UI is reset.
//TODO could also just reset the scene.































