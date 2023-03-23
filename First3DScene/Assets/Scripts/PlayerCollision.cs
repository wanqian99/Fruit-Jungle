using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Score score;
    [SerializeField] AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fruit")
        {
            // Play sound when collect fruit
            audioSource.Play();

            // Destroy the fruit, along with its child object,
            // the fruitIcon(sprite renderer)
            Destroy(other.gameObject);
            score.AddScore();
        }
    }
}
