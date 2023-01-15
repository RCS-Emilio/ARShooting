using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public float timeRemaining = 30;
    public TextMeshProUGUI remaining;
    public TextMeshProUGUI score;
    public static int globalScore = 0;
    private int topOne, topTwo, topThree;

    public TextMeshProUGUI finalScore;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        topOne = PlayerPrefs.GetInt("One", 0);
        topTwo = PlayerPrefs.GetInt("Two", 0);
        topThree = PlayerPrefs.GetInt("Three", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
            score.text = globalScore.ToString();
        } else {
            StartCoroutine(GameEnd());
        }
    }

    void DisplayTime(float timeToDisplay) {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        remaining.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void CompareScore(int one, int two, int three, int newscore) {
        var auxOne = one;
        var auxTwo = two;


        if (newscore >= one) {
            PlayerPrefs.SetInt("One", newscore);
            PlayerPrefs.SetInt("Two", auxOne);
            PlayerPrefs.SetInt("Three", auxTwo);
            return;
        }

        if (newscore >= two) {
            PlayerPrefs.SetInt("Two", newscore);
            PlayerPrefs.SetInt("Three", auxTwo);
            return;
        }

        if (newscore >= three) {
            PlayerPrefs.SetInt("Three", newscore);
            return;
        }



    }

    IEnumerator GameEnd() {
        CompareScore(topOne, topTwo, topThree, globalScore);
        PlayerPrefs.Save();
        panel.SetActive(true);
        finalScore.text = "TU PUNTUACIÓN FUE: " + globalScore.ToString();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MainMenu");
    }


}



