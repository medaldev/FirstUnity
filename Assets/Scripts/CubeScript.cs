using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public GameObject Cube;

    float smooth = 50.0f;
    float tiltAngle = 60.0f;
    public float cubeSpeed;

    public float S;

    float Ver, Hor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void move()
    {
        Ver = Input.GetAxis("Vertical") * Time.deltaTime * 10;
        Hor = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        Cube.transform.Translate(new Vector3(Hor, 0, Ver));
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            move();
        }

       if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            move();
        }

       if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            move();
        }

       if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            move();
        }
       
       if (Input.GetMouseButton(0))
        {
            var mousePosition = Input.mousePosition;
            mousePosition.z = transform.position.z - Camera.main.transform.position.z; // это только для перспективной камеры необходимо
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //положение мыши из экранных в мировые координаты
            var angle = 180 + 90 + Vector2.Angle(Vector2.right, mousePosition - transform.position);//угол между вектором от объекта к мыше и осью х
            transform.eulerAngles = new Vector3(0f, transform.position.z < mousePosition.z ? angle : -angle, 0f);//немного магии на последок

           
        }



    }

    
}
