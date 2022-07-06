using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int score;
    public GameObject PauseScreen;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
         
    }

    // Update is called once per frame
    void Update()
    {
        
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
