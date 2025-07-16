using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed;
    public Camera gameCamera;

    private float change;

    private int xdirection = 1;
    private int ydirection = 1;

    //float r = random(0.0005, 0.05);

    

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

        Vector3 newScale = transform.scale * change;

        transform.position += Vector3.right * speed * xdirection;
        transform.position += Vector3.up * speed * ydirection;

        Vector3 pacerPositionInScreenSpace = gameCamera.WorldToScreenPoint(transform.position);

        if (pacerPositionInScreenSpace.x > Screen.width)
        {
            xdirection *= -1;
        }
        if (pacerPositionInScreenSpace.x < 0)
        {
            xdirection *= -1;
        }

        if (pacerPositionInScreenSpace.y > Screen.height)
        {
            ydirection *= -1;
        }
        if (pacerPositionInScreenSpace.y < 0)
        {
            ydirection *= -1;
        }


        if (up == true)
        {
            change = 2;
        }

        if (down == true)
        {
            change = 0.5;
        }

        if (right == true)
        {
            speed *= 2f;
        }
        if (left == true)
        {
            speed *= 0.5f;
        }
    }
}