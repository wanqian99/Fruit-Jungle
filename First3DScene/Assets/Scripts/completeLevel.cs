using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class completeLevel : MonoBehaviour
{
    public Score score;
    public spawnFruit spawnFruit;

    // Update is called once per frame
    void Update()
    {
        int totalFruit = spawnFruit.fruitCount;
        if (totalFruit == score.score)
        {
            Debug.Log("You have cleared the game!");
            // Loads the next scene (end scene)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
