using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() // Move from scene 1 (Menu) to scene 2 (level)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void QuitGame() // Quit
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
