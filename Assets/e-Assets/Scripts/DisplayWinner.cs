using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayWinner : MonoBehaviour
{
    // Player & Opponent References
    private GameObject opponent;
    private Opponent opponentScript;
    private GameObject player;
    private Player playerScript;

    [SerializeField]
    private TextMeshProUGUI winnerDisplay;

    void Start()
    {
        winnerDisplay.text = "";
        opponent = GameObject.FindGameObjectWithTag("Opponent");
        opponentScript = opponent.GetComponent<Opponent>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (opponentScript.health <= 0) {
            winnerDisplay.text = "A winner is you!";
            ResetText();
        }

        if (playerScript.health <= 0) {
            winnerDisplay.text = "A winner is not you!";
            ResetText();
        }
        
        
    }

    

    IEnumerator ResetText() {
        yield return new WaitForSeconds(2f);
        playerScript.health = 3;
        opponentScript.health = 3;

    }

}
