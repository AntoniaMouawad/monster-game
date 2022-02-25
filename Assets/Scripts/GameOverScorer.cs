using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScorer : MonoBehaviour
{
    // Start is called before the first frame update
    private int currentScore;
    private Text finalScore;
    private void Awake()
    {
        finalScore = GameObject.Find("Final Score").GetComponent<Text>();
    }
    private void Start()
    {
        currentScore = ScoreTracker.instance.CurScore;
        finalScore.text = "Final Score: " + currentScore;
        Destroy(GameObject.FindGameObjectWithTag("ScoreTracker"));
    }
}
