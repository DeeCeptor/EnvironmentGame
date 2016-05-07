using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour
{
    public void GoToMenu()
    {
        Application.Quit();
        //UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    public void Quit_Application()
    {
        Application.Quit(); 
    }
}
