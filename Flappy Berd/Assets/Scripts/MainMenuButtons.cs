using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public Animator transitions;
    public void StartGame()
    {
        StartCoroutine(LoadLevel());
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    IEnumerator LoadLevel()
    {
        transitions.SetTrigger("Start"); //start animation
        yield return new WaitForSeconds(1); //wait 1 second
        SceneManager.LoadScene("Game"); //transition scenes
    }
}
