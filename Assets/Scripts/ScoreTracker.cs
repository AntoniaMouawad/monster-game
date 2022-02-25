using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    private TextMeshProUGUI score;
    private float timer;
    private int curScore;
    // Start is called before the first frame update
    void Awake()
    {
        score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        updateScore(0);

    }

    void updateScore(int curScore)
    {
        score.text = "Score: " + curScore;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f)
        {
            curScore += 1;
            updateScore(curScore);
            timer = 0;
        }
        
    }
}
