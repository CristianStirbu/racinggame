using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void startgame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("the game has started");
   }

    public void quitgame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
