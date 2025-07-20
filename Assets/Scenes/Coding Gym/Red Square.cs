using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSquare : MonoBehaviour
{
    bool overlap;
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

        if (mousePositionInWorldSpace.x <= 1 && mousePositionInWorldSpace.x >=- 1 && mousePositionInWorldSpace.y >= -1 && mousePositionInWorldSpace.y <= 1)
        {
            overlap |= true;
        } else
        {
            overlap = false;
        }

        if (overlap == true)
        {
            chaserRenderer.color = Color.red;
        }
        else
        {
            chaserRenderer.color = Color.white;
        }
    }
}
