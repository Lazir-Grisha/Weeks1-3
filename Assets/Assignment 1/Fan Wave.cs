using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanWave : MonoBehaviour
{
    bool fanup;

    // Start is called before the first frame update
    void Start()
    {
        fanup = true;
    }

    // Update is called once per frame
    void Update()
    {
        //transform to flap fan
        Vector3 newRotation = transform.eulerAngles;
        //if statements and boolean to determine fan postion

        if (Input.GetMouseButtonDown(0) && fanup == true)
        {
            fanup = false;
            newRotation.z = -50.12f;
            transform.eulerAngles = newRotation;
            //set fan z rotation to -116.34
        }
        else if (Input.GetMouseButtonDown(0) && fanup == false)
        {
            fanup = true;
            newRotation.z = -6.12f;
            transform.eulerAngles = newRotation;
            //set fan z rotation to - 50.12
        }
    }
}
