using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMeRound : MonoBehaviour
{
    //blades rotate around center on spacebar
    public float speed;
    bool on;
    // Start is called before the first frame update
    void Start()
    {
        on = false;
    }

    // Update is called once per frame
    void Update()
    {

        //code that determines if the fan is being turned on/off
        if (on == false)
        {
            speed = 0f;
        }
        else if (on == true)
        {
            speed = 0.5f;
        }

        //code that lets the fan blades rotate around the fan center
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed;
        transform.eulerAngles = newRotation;
    }
    public void OnClickSpin()
    {
        //if statements to turn fan on and off with button pressed
        if (on == true)
        {
            on = false;
        }
        else if (on == false)
        {
            on = true;
        }
    }
}
