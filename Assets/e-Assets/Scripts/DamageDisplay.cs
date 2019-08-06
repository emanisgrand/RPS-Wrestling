using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageDisplay : MonoBehaviour
{
    //Text mesh holder
    public TextMeshProUGUI OpponentTmpText, PlayerTmpText;

    // Player & Opponent References
    private GameObject opponent;
    private Opponent opponentScript;
    private GameObject player;
    private Player playerScript;

    private void Awake() {
        opponent = GameObject.FindGameObjectWithTag("Opponent");
        opponentScript = opponent.GetComponent<Opponent>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player>();
    }

    //TODO: Make an UpdateUI function that is called whenever the values change.
    void Update()
    {
        PlayerTmpText.text = "Player: " + playerScript.health.ToString();
        OpponentTmpText.text = "Opponent: " + opponentScript.health.ToString();
    }
}
