using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class CircleMover : MonoBehaviour
{

    public float xspeed;
    public float yspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

             bool up = Input.GetKeyDown(KeyCode.UpArrow);
     bool down = Input.GetKeyDown(KeyCode.DownArrow);
     bool left = Input.GetKeyDown(KeyCode.LeftArrow);
     bool right = Input.GetKeyDown(KeyCode.RightArrow);

    Vector3 newxPosition = transform.position + Vector3.right * xspeed;
        transform.position = newxPosition;

        Vector3 newyPosition = transform.position + Vector3.up * yspeed;
        transform.position = newyPosition;

        xspeed = 0;
        yspeed = 0;


        if (up == true)
        {
            yspeed = 0.1f;
        }

        if (down == true)
        {
            yspeed = -0.1f;
        }

        if (right == true)
        {
            xspeed = 0.5f;
        }
        if (left == true)
        {
            xspeed = -0.5f;
        }
    }
}
