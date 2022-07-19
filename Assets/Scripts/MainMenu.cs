using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Text bestScoreText;

    private void Start()
    {
        int bestScore = PlayerPrefs.GetInt(GameManager.BestScoreKey, 0);
        bestScoreText.text = $"Best Score\n{bestScore}";

    } 
    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }
}
