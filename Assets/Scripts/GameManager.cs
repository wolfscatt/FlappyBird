using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int score;
    public GameObject PauseScreen;
    public GameObject FirstScreen;
    public GameObject PlayScreen;
    public Text scoreText;
    public const string BestScoreKey = "BestScore";
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDestroy()
    {
        int currentBestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
        if (score>currentBestScore)
        {
            PlayerPrefs.SetInt(BestScoreKey, score);
        }
    }
    public void ScoreUpdate()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void FirstScreenPlay()
    {
        FirstScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        PauseScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayGame()
    {
        PauseScreen.SetActive(false);
        Time.timeScale = 1;
        
    }
}
