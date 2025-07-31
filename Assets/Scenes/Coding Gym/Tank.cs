using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float xspeed;
    public float speedboost;
    bool gearShift;
    public SpriteRenderer tankRenderer;
    bool colorChange;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);

        Vector3 newxPosition = transform.position + Vector3.right * xspeed * speedboost;
        transform.position = newxPosition;


        xspeed = 0;

        if (right == true)
        {
            xspeed = 0.5f;
        }
        if (left == true)
        {
            xspeed = -0.5f;
        }

        if (gearShift == true)
            {
            speedboost = 2;
        }
        else
        {
            speedboost = 1;
        }

    }
    public void OnClickSpeed()
    {
        if (gearShift == false)
            {
            gearShift = true;
        } else if (gearShift == true)
        {
            gearShift = false;
        }
    }
    public void OnClickColor()
    {
        if (colorChange == true)
        { colorChange = false;
            tankRenderer.color = Color.red;
        } else if (colorChange == false)
        {
            colorChange = true;
            tankRenderer.color = Color.green;
        }
    }
}
