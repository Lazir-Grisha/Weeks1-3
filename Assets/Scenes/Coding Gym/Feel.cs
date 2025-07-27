using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feel : MonoBehaviour
{
    public bool overlap;
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

        if (mousePositionInWorldSpace.x <= 6 && mousePositionInWorldSpace.x >= 4 && mousePositionInWorldSpace.y >= -1 && mousePositionInWorldSpace.y <= 1)
        {
            overlap |= true;
        }
        else
        {
            overlap = false;
        }


    }
}