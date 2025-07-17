using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : MonoBehaviour
{
    //Jupiter dissapears and reappears on space
    bool display; //a variable to determine whether or not Jupiter is visible
    // Start is called before the first frame update
    void Start()
    {
        display = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;
        bool Space = Input.GetKeyDown(KeyCode.Space);
        //if statements to turn display on/off when space is pressed
        //to dissapear it shrinks into nothing
        if (display == true && Space == true)
        {
            display = false;
            newScale.x = 0;
            newScale.y = 0;
            transform.localScale = newScale;
        }
        else if (display == false && Space == true)
        {
            display = true;
            newScale.x = 2.52944f;
            newScale.y = 2.529443f;
            transform.localScale = newScale;

        }
    }
}
