using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public GameObject Cube;

    float smooth = 50.0f;
    float tiltAngle = 60.0f;
    public float cubeSpeed;

    public float S;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow))
        {
            Cube.transform.position += (new Vector3(0, 0, cubeSpeed) * Time.deltaTime * Time.deltaTime);
        }

       if (Input.GetKey(KeyCode.DownArrow))
        {
            Cube.transform.position += (new Vector3(0, 0, -cubeSpeed) * Time.deltaTime * Time.deltaTime);
        }

       if (Input.GetKey(KeyCode.RightArrow))
        {
            Cube.transform.position += (new Vector3(cubeSpeed, 0, 0) * Time.deltaTime * Time.deltaTime);
        }

       if (Input.GetKey(KeyCode.LeftArrow))
        {
            Cube.transform.position += (new Vector3(-cubeSpeed  , 0, 0) * Time.deltaTime * Time.deltaTime);
        }
       
       if (Input.GetMouseButton(0))
        {
    // Smoothly tilts a transform towards a target rotation.
            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

            Vector3 point = new Vector3();
            var mousePos = Input.mousePosition;
            point = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, S));
            float angle = Mathf.Atan2(mousePos.y - Cube.transform.position.y, mousePos.x - Cube.transform.position.x) * Mathf.Rad2Deg;

            // Rotate the cube by converting the angles into a quaternion.
            Quaternion target = Quaternion.Euler(0, -Math.Abs(angle) * 10, 0);



            // Dampen towards the target rotation
            Cube.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }

        

    }

    
}
