using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    //If the mouse is within a certain distance of this object
    //Change its colour

    public float colourChangeDistance;

    SpriteRenderer detectorRenderer;


    // Start is called before the first frame update
    void Start()
    {
        detectorRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 firstPosition = transform.position;
        Vector3 secondPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        secondPosition.z = 0f;

        float distanceBetweenPositions = Vector3.Distance(firstPosition, secondPosition);
        Debug.Log(distanceBetweenPositions);

        if (distanceBetweenPositions < colourChangeDistance)
        {
            detectorRenderer.color = Color.black;
        }


    }
}
