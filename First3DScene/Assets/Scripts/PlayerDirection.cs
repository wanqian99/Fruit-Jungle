using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirection : MonoBehaviour
{
    Camera cam;
    Ray mouseRay;
    Vector3 hitpoint;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //Create a ray pointing from camera to mouse position on screen
        mouseRay = cam.ScreenPointToRay(Input.mousePosition);

        // To store information of where the ray hit
        RaycastHit hitInfo;

        //Extract vector information from the hitInfo
        if (Physics.Raycast(mouseRay, out hitInfo, 100f))
        {
            hitpoint = hitInfo.point;
        }

        // using only the x and z value of the hitpoint,
        // since I don't want the camera to be looking up or down on the player
        Vector3 lookTarget = new Vector3(hitpoint.x, transform.position.y, hitpoint.z);
        //Rotating the object to that point
        transform.LookAt(lookTarget);
    }
}
