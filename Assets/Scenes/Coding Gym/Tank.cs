using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankl : MonoBehaviour
{
    public float xspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);

        Vector3 newxPosition = transform.position + Vector3.right * xspeed;
        transform.position = newxPosition;


        xspeed = 0;

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
