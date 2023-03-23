using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    public void Restart()
    {
        //Loads first scene
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
