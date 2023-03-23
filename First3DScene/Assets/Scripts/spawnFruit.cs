using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFruit : MonoBehaviour
{
    public GameObject[] fruitAssets;
    public Sprite sprite;
    public int fruitCount;
    private GameObject FruitIcon;

    public Vector3 randomPosition;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < fruitCount; i++)
        {
            int randomIndex = Random.Range(0, fruitAssets.Length);
            randomPosition = new Vector3(Random.Range(-5.8f, 22),
                                         Random.Range(1, 4),
                                         Random.Range(-5.8f, 22));

            GameObject fruitObject = Instantiate(fruitAssets[randomIndex],
                                                 randomPosition,
                                                 Quaternion.identity);

            //Generate sprite for the minimap (to display where the fruits are at)
            GenerateSpriteRenderer();

            // Make the FruitIcon the child of the Fruit object
            FruitIcon.transform.SetParent(fruitObject.transform);
        }
    }

    void GenerateSpriteRenderer()
    {
        // Create new game object
        FruitIcon = new GameObject("FruitIcon");

        // Set it to layer 10, to show it on the minimap
        FruitIcon.layer = 10;

        // Create a sprite renderer, to use it as the fruit's location on the minimap
        SpriteRenderer renderer = FruitIcon.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;

        // Set the sprite's color
        Color color;
        if (ColorUtility.TryParseHtmlString("#FF4C4C", out color))
        {
            renderer.color = color;
        }

        // Set the sprite's position to be the same as the fruit object's position
        FruitIcon.transform.position = new Vector3(randomPosition.x, 15f, randomPosition.z);
        FruitIcon.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        FruitIcon.transform.localScale = new Vector3(10, 10, 1);
    }
}
