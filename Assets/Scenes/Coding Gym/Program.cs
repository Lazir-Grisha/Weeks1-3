using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{
    public bool overlap;
    public float change;
    public Camera gameCamera;
    public SpriteRenderer chaserRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);

        if (mousePositionInWorldSpace.x <= -4 && mousePositionInWorldSpace.x >= -6 && mousePositionInWorldSpace.y >= -1 && mousePositionInWorldSpace.y <= 1)
        {
            overlap |= true;
            change += 1;
        }
        else
        {
            overlap = false;
        }


    }
}
