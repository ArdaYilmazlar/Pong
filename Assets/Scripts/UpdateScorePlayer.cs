using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScorePlayer : MonoBehaviour
{
    public ScoreUI scoreUI;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ball")
        {
            scoreUI.playerScore++;
            scoreUI.scoreUpdate();
        }
    }
}
