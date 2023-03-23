using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    Camera cam;
    private Vector3 originPosition;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float Zoffset;

    // Start is called before the first frame update
    void Start()
    {
        // initialize main camera
        cam = Camera.main;
    }

    // LateUpdate is called after Update and FixedUpdate
    // This is to optimize the code, so that camera follows player after the player has moved(transform)
    private void LateUpdate()
    {
        // camera follows player
        transform.position = playerTransform.position;

        // mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // save mouse position
            originPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        // mouse drag to pan camera
        // eg. if mouse move from left to right, the mouse position difference
        // multiplied by 180degree will be the angle to rotate the camera
        else if (Input.GetMouseButton(0))
        {
            // get the new mouse position
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);

            // calculate the difference between the 2 mouse positions
            Vector3 direction = originPosition - newPosition;

            // calculate the angle to rotate around y axis
            float rotation = -direction.x * 180; // camera moves horizontally

            // rotates camera around player
            transform.RotateAround(playerTransform.position ,new Vector3(0, 1, 0), rotation);

            // make the newPosition to be the originPosition
            originPosition = newPosition;
        }

        //translate to offset the camera
        transform.Translate(new Vector3(0, 0, -Zoffset));
    }
}
