using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SquareMover : MonoBehaviour
{
    //Class variables
    public float speed;
    float xMax;
    float xMin;

    // Start is called before the first frame update
    void Start()
    {

        //Vector 3 = PVector or (x,y,z)
        //Variable type then name of Variable

        //Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 newPosition = transform.position + Vector3.right * 1f;

        transform.position = newPosition;
        speed = 0.05f;
        xMax = 8;
        xMin = -8;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.right * speed;
        transform.position = newPosition;

        if (transform.position.x >= xMax)
        {
            speed = -0.05f;
        }
        else if (transform.position.x <= xMin)
        {
            speed = 0.05f;
        }


            }
    }
