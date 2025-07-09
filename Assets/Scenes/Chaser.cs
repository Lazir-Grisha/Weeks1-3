using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCamera;
    public SpriteRenderer chaserRenderer;

    public float speed;
    Vector3 lastClickedPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;

        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPosition = mousePositionInWorldSpace;
        }

        Vector3 start = transform.position;
        Vector3 target = lastClickedPosition;
        Vector3 directionToMove = target - start;

        //transform.position = transform.position + directionToMove * speed;

        Vector3 chaserPositionInScreenSpace = gameCamera.WorldToScreenPoint(transform.position);
        //Debug.Log("ChaserPosition in ScreenSpace = " + chaserPositionInScreenSpace.ToString());
        float xMin = 0f;
        float yMin = 0f;
        float xMax = Screen.width;
        float yMax = Screen.height;

        //If chaser's x value is less than the xMin
        //If chaser's x value is greater than the xMax
        //If chaser's y value is less than the yMin
        //If chaser's y value is greater than the yMax
        //THEN:
        //Change the colour of the sprite to be red

        bool xMaxExceeded = chaserPositionInScreenSpace.x >= xMax;
        bool xMinExceeded = chaserPositionInScreenSpace.x <= xMin;

        Debug.Log("xMaxExceeded = " + xMaxExceeded.ToString());
        Debug.Log("xMinExceeded = " + xMinExceeded.ToString());
        if (xMaxExceeded || xMinExceeded)
        {
            //Change the colour of the sprite
            chaserRenderer.color = Color.red;
        }
        else
        {
            chaserRenderer.color = Color.white;
        }
    }
}