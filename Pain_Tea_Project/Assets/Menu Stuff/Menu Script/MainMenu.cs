using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject controlMenu;
    public GameObject basicMenu;

    public int index;


    public void OpenControls()
    {
        controlMenu.SetActive(true);
        basicMenu.SetActive(false);
    }

    public void CloseControls()
    {
        controlMenu.SetActive(false);
        basicMenu.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(index);
    }

    public void QuitGame()
    {
        Debug.Log("Please, quit game :)");
        Application.Quit();
    }
}
