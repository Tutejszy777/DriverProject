using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasManager : MonoBehaviour
{

    public TMP_Text timeText;

    public GameObject endGamePanel;
    public TMP_Text runTimeText;
    public TMP_Text highScoreText;

    public float elapsedTime;
    public float startTime;
    
    void Start()
    {
        startTime = Time.time + 3; //3 seconds delay for animation
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }

    public void UpdateTime()
    {
        elapsedTime = Time.time - startTime;
        timeText.text = "Time \n" + elapsedTime.ToString("F2");
    }

    public void EndGame()
    {
        // TODO: Setup EndGame Panel
        endGamePanel.SetActive(true);

        float checkTime = PlayerPrefs.GetFloat("BestScore",0);

        if (elapsedTime > checkTime)
        {
            PlayerPrefs.SetFloat("BestScore", elapsedTime);
            highScoreText.text = "New Best Score: \n" + elapsedTime.ToString("F2");
        }
        else
        {
            highScoreText.text = "Best Score: \n" + checkTime.ToString("F2");
        }

        runTimeText.text = "Current time: \n" + elapsedTime.ToString("F2");
    }

    public void RestartGame()
    {
        // TODO: Restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        // TODO: Quit Game
        Application.Quit();
    }
}
