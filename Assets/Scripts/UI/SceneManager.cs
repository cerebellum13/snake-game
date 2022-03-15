using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public void GoToGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void GoToGameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
