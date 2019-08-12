using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum GamesChoices {   
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}

public class GameplayController : AbstractBehavior {

    // Player & Opponent References
    private Animator            oppAnimator, playerAnimator;
    private GameObject          opponent;
    private Opponent            opponentScript;
    private GameObject          player;
    private Player              playerScript;
    private bool                canPlay;
    private Rigidbody           opponentRigidBody;
    private GameObject          winnerDisplay;
    private CapsuleCollider     opponentCollider;

    private float               defaultCapsuleHeight = 1.828423f;

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
        oppAnimator         = opponent.GetComponent<Animator>();
        player              = GameObject.FindGameObjectWithTag("Player");
        playerScript        = player.GetComponent<Player>();       
        playerAnimator      = player.GetComponent<Animator>();
        opponentRigidBody   = opponent.gameObject.GetComponent<Rigidbody>();
        opponentCollider    = opponent.GetComponent<CapsuleCollider>();
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
            infoText.text = "zzzzzzz";
            Ungrapple();
            StartCoroutine(DisplayWinnerAndRestart());
            return;

        }

        if(player_Choice == GamesChoices.PAPER && opponent_Choice == GamesChoices.ROCK ||
            player_Choice == GamesChoices.SCISSORS && opponent_Choice == GamesChoices.PAPER ) {
            // player won
            opponentScript.TakeDamage(1);
            infoText.text = "FANCY!";
            StartCoroutine(DisplayWinnerAndRestart());
            StartCoroutine(PlayerAttackAnim());
            return;
        }

        if (player_Choice == GamesChoices.ROCK && opponent_Choice == GamesChoices.SCISSORS){
            opponentScript.TakeDamage(1);
            infoText.text = "ROCK!";
            StartCoroutine(DisplayWinnerAndRestart());
            StartCoroutine(RockAnim());
            return;
        }

        if (opponent_Choice == GamesChoices.PAPER && player_Choice == GamesChoices.ROCK ||
            opponent_Choice == GamesChoices.ROCK && player_Choice == GamesChoices.SCISSORS ||
            opponent_Choice == GamesChoices.SCISSORS && player_Choice == GamesChoices.PAPER ) {
            // opponent won
            playerScript.TakeDamage(1);
            
            infoText.text = "KICK ROCKS";
            StartCoroutine(DisplayWinnerAndRestart());
            StartCoroutine(OpponentAttackAnim());
            return;
        }       
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

    //* take in an array of possible animations or animation triggers set by the choice that gets made */
    IEnumerator PlayerAttackAnim() {                        
       oppAnimator = opponent.GetComponent<Animator>();
       playerAnimator = player.GetComponent<Animator>();
       //* foreach (animation in animations[]) {  } */
       opponentScript.isGrappled    = false;
       //In Opponent.OnTriggerEnter, The Opponent's transform is parented to an empty game obj that is attached to the player. 
       //Here we unparent the Opponent's transform.
       opponent.transform.parent    = null;  
       oppAnimator.SetBool("isGrappled", false);
       playerAnimator.SetBool("won", true);
       oppAnimator.SetBool("lost", true);
       opponentCollider.height = 0.25f;
       yield return new WaitForSeconds(4f);
       opponentCollider.height = defaultCapsuleHeight;
       playerAnimator.SetBool("won", false);
       oppAnimator.SetBool("lost", false);
    }

    IEnumerator OpponentAttackAnim() {                         
        
        oppAnimator = opponent.GetComponent<Animator>();
        playerAnimator = player.GetComponent<Animator>();

        opponentScript.isGrappled = false;
        //In Opponent.OnTriggerEnter, The Opponent's transform is parented to an empty game obj that is attached to the player. 
        //Here we unparent the Opponent's transform.
        opponent.transform.parent = null;
        oppAnimator.SetBool("isGrappled", false);
        playerAnimator.SetBool("lost", true);
        oppAnimator.SetBool("won", true);        
        //*  use animation time */
        yield return new WaitForSeconds(4f);  
        playerAnimator.SetBool("lost", false);
        oppAnimator.SetBool("won", false);
    }

    IEnumerator RockAnim()
    {

        oppAnimator = opponent.GetComponent<Animator>();
        playerAnimator = player.GetComponent<Animator>();

        opponentScript.isGrappled = false;
        //In Opponent.OnTriggerEnter, The Opponent's transform is parented to an empty game obj that is attached to the player. 
        //Here we unparent the Opponent's transform.
        opponent.transform.parent = null;
        oppAnimator.SetBool("isGrappled", false);
        playerAnimator.SetBool("isRock", true);
        oppAnimator.SetBool("rockHit", true);
        //*  use animation time */
        yield return new WaitForSeconds(4f);
        playerAnimator.SetBool("isRock", false);
        oppAnimator.SetBool("rockHit", false);
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































