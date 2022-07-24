using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    void Start()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void ControllsMenu()
    {
        SceneManager.LoadScene("ControllsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
