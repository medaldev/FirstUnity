using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Cube;
    public Camera cam;

    private int x = 0;
    private int y = 25;
    private int z = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = Cube.transform.position + new Vector3(x, y, z);
    }
}
