using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniMap : MonoBehaviour
{
    public Transform player;

    // called after Update() and FixedUpdate()
    // so that minimap is only updated after our player has moved
    void LateUpdate()
    {
        // set position of minimap to be player's position
        Vector3 newPosition = player.position;

        // set the y value to the current y position
        newPosition.y = transform.position.y;

        // so that map moves along
        transform.position = newPosition;
    }
}
