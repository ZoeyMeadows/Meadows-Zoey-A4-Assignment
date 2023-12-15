using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private GameObject gameOverCanvas;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Time.timeScale = 1.0f; //turn time on
    }
    private void Start()
    {
        gameOverCanvas.SetActive(false); // turn off game over screen
    }
    public void gameOver()
    {
        gameOverCanvas.SetActive(true); // turn on game over screen
        Time.timeScale = 0f; //stop time (za warudo)
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//reload scene
    }
    public void MainMenu()
    {
        Application.Quit(); //originally this went to main menu but now things are breaking and I cannot figure out how to fix it so this works instead
    }
}
