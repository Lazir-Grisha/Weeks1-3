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
        //if statements and boolean to determine fan postion
        
         if (Input.GetMouseButtonDown(0) && fanup == true)
        {
            fanup = false;
            //set fan z rotation to -116.34
        }
        if (Input.GetMouseButtonDown(0) && fanup == false)
        {
            fanup = true;
            //set fan z rotation to - 50.12
        }
    }
}
