using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject pauseMenu;
    //public GameObject deathmenu;


    public void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            pauseMenu.SetActive(true);
        }
    }
    public void ButtonContinue()
    {
        pauseMenu.SetActive(false);
    }
    public void ButtonExit()
    {
        SceneManager.LoadScene(0);
    }
    public void ButtonRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ButtonQuit()
    {
        Application.Quit();
    }
}
