using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public GameObject withoutPauseUI;
    public GameObject pauseUI;

    private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if(isPaused)
        {
            ActivateMenu();
        } 
        else 
        {
            DisableMenu();
        }
    }

    void ActivateMenu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        AudioListener.pause = true;
        withoutPauseUI.SetActive(false);
        pauseUI.SetActive(true);
    }

    public void DisableMenu()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        AudioListener.pause = false;
        withoutPauseUI.SetActive(true);
        pauseUI.SetActive(false);
        isPaused = false;
    }
}
