using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidBellows : MonoBehaviour
{
    //Bellows dissapears and reappears based on number, number changes with right click
    bool one;
    bool two;
    bool three;
    // Start is called before the first frame update
    void Start()
    {
        one = true;
        two = false;
        three = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;
        //code cycles through numbers to see if displayed.

        if (Input.GetMouseButtonDown(0) && one == true)
        {
            one = false;
            two = true;
            three = false;
           
        }
        else if (Input.GetMouseButtonDown(0) && two == true)
        {
            one = false;
            two = false;
            three = true;

        }
        else if (Input.GetMouseButtonDown(0) && three == true)
        {
            one = true;
            two = false;
            three = false;

            
           //displays on two
        }
        if (two == true)
        {
            newScale.x = 1;
            newScale.y = 1;
            newScale.z = 1;
            transform.localScale = newScale;
        } else
        {
            newScale.x = 0;
            newScale.y = 0;
            newScale.z = 0;
            transform.localScale = newScale;
        }
    }
}
