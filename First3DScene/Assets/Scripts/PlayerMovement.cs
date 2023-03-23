using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float jumpHeight;

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxisRaw("Vertical");

        // forward and backward motion. +z is forward, -z is backward
        // Time.deltaTime makes frame rate independent
        transform.Translate(new Vector3(0, 0, movement) * movementSpeed * Time.deltaTime);

        // jump
        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(new Vector3(0, jumpHeight, 0));
        }
    }
}
