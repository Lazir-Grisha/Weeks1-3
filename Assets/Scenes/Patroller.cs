using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public Vector3 startValue;
    public Vector3 endValue;
    public float currentTime;

    bool moveForward = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moveForward)
        {
            currentTime += Time.deltaTime;

            //if(currentTime > 1f)
            if (endValue == transform.position)
            {
                moveForward = false;
            }
        }
        else
        {
            currentTime -= Time.deltaTime;

            //if(currentTime < 0f)
            if (startValue == transform.position)
            {
                moveForward = true;
            }
        }


        Vector3 output = Vector3.Lerp(startValue, endValue, currentTime);
        transform.position = output;



    }
}
