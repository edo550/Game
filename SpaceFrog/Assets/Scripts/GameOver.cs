using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    //public static bool GameIsPaused = false;

    public GameObject gameOverUI;

    // Update is called once per frame
    /*public void Game()
    {
        if (GameIsPaused==false)
        {
            Pause();
        }
    }
    */
    public void Game()
    {
        gameOverUI.SetActive(true);
    }



    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
    public void Restart1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game 1");
    }
    public void Restart2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game 2");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
