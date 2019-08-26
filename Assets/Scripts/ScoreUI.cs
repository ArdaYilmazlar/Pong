using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
     public int playerScore = 0;
     public int cpuScore = 0;

    public GameObject playerGoalBoundry;
    public GameObject cpuGoalBoundry;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = string.Format("{0} - {1}", playerScore, cpuScore);
    }

    public void scoreUpdate()
    {
        scoreText.text = string.Format("{0} - {1}", playerScore, cpuScore);
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("black");
        if (collision.Equals(playerGoalBoundry))
            Debug.Log("Sup");
    }
    void Update()
    {
        
    }
}
