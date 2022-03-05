using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UINavigation : MonoBehaviour
{
    private void Start() {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
   public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    } 

    public void LoadGame()
    {
        SceneManager.LoadScene("GameMain");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
