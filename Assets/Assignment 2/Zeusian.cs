using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeusian : MonoBehaviour
{
    //Jupiter shrinks on button press and changes colour
    bool shrink; //a variable to determine whether or not Jupiter is shrunken
    public SpriteRenderer jupiterRenderer;

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
            jupiterRenderer.color = new Color(0.5471698f, 0.2625563f, 0.07484871f); //https://discussions.unity.com/t/change-color-in-c-with-rgb-values/168605
        }
        else if (shrink == false)
        {
            shrink = true;
            jupiterRenderer.color = new Color(0.7075472f, 0.3833696f, 0.1702118f);
        }
    }
}
