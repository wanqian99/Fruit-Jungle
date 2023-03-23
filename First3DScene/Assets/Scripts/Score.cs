using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public spawnFruit spawnFruit;
    public Text scoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int totalFood = spawnFruit.fruitCount;
        scoreText.text = "Fruits: " + score.ToString("0") + "/" + totalFood;
    }

    public void AddScore()
    {
        score++;
    }
}
