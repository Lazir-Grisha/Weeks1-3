using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed;
    public Camera gameCamera;

    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction;

        Vector3 pacerPositionInScreenSpace = gameCamera.WorldToScreenPoint(transform.position);

        if (pacerPositionInScreenSpace.x > Screen.width)
        {
            direction *= -1;
        }
        if (pacerPositionInScreenSpace.x < 0)
        {
            direction *= -1;
        }


    }
}