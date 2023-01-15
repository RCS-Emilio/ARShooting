using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    void Start()
    {
        var topOne = PlayerPrefs.GetInt("One", 0);
        var topTwo = PlayerPrefs.GetInt("Two", 0);
        var topThree = PlayerPrefs.GetInt("Three", 0);

        loadScores(topOne, one);
        loadScores(topTwo, two);
        loadScores(topThree, three);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadScores(int score, TextMeshProUGUI scoreText) {
        if (score == 0) {
            scoreText.text = "NO PLAYER";
        } else {
            scoreText.text = "HIGHSCORE: " + score;
        }
    }
}
