using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour

{
    public GameObject ball;
    public  Text text;
    private bool newGoal = true;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = ball.transform.position.x;
        float z = ball.transform.position.z;
        if ((x > 9 && x < 17) && (z > 36 && z < 38))
        {
            if (newGoal)
            {
                counter++;
                text.text = counter.ToString();
            }
            newGoal = false;

        }
        else
        {
            newGoal = true;
        }
    }
}
