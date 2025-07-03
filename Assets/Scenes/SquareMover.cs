using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SquareMover : MonoBehaviour
{
    //Class variables
    float speed;

    // Start is called before the first frame update
    void Start()
    {

        //Vector 3 = PVector or (x,y,z)
        //Variable type then name of Variable

        //Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 newPosition = transform.position + Vector3.right * 1f;

        transform.position= newPosition;       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
