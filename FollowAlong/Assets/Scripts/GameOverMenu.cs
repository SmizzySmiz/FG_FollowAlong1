using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// Neccassary to add!!!!!

public class GameOverMenu : MonoBehaviour
{
    public void Restart() // Return to level to play again
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame() // Quits game
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
