using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : MonoBehaviour
{

    bool display; //a variable to determine whether or not Jupiter is visible
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        bool Space = Input.GetKeyDown(KeyCode.Space);
        //if statements to turn display on/off when space is pressed
        if (display == true && Space == true)
        {
            display = false;
        }
        if (display == false && Space == true)
        {
            display = true;
        }
    }
}
