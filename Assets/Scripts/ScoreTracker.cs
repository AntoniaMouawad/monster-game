using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public static ScoreTracker instance;
    private TextMeshProUGUI score;
    private float timer = 0f;
    private int _curScore;
    public int CurScore
    {
        get { return _curScore; }
        set { _curScore = value; }
    }
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
        Debug.Log(timer);
        if (timer > 3f)
        {
            CurScore += 1;
            updateScore(CurScore);
            timer = 0f;
        }
        
    }
}
