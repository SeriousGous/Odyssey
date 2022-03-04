using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_menu : MonoBehaviour
{
    public static bool GameIsPaused = true;
    public GameObject mainmenuUI;
   
    /*void Update()
    {
        
    }*/
    void Start() {
        Time.timeScale = 0f;
    }
    public void restart()
    {
        Debug.Log("pain");
    }
    public void Start_butt()
    {
        mainmenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("pain");
    }/*
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("pain");
    }*/
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
