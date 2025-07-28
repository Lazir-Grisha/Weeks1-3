using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeusian : MonoBehaviour
{
    //Jupiter shrinks on button press
    bool shrink; //a variable to determine whether or not Jupiter is shrunken
    // Start is called before the first frame update
    void Start()
    {
        shrink = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;

        if (shrink == true)
        {
            newScale.x = 3.5f;
            newScale.y = 3.5f;
            transform.localScale = newScale;
        }
        else if (shrink == false)
        {
            newScale.x = 6.488745f;
            newScale.y = 6.488745f;
            transform.localScale = newScale;

        }
    }

    public void OnClickShrink()
    {
        //if statements to shrink when button pressed
        if (shrink == true)
        {
            shrink = false;
        }
        else if (shrink == false)
        {
            shrink = true;
        }
    }
}
