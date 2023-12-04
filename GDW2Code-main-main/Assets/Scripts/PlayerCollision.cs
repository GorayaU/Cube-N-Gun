using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static bool GameIsOver = false;

    public GameObject GameOverUI;
    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverUI.SetActive(true);
        GameIsOver = true;
    }

    public void LoadMenu()
     {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
     }

}
