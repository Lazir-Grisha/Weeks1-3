using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Camera gameCamera;

    private float directionx;
    private float directiony;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        directionx = mousePositionInWorldSpace.x;
        directiony = mousePositionInWorldSpace.y;

        //Vector3 = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;

    }

    // Update is called once per frame
    void Update()
    {

        //transform.position += Vector3.right * speed * directionx;


        //Vector3 bulletPositionInScreenSpace = gameCamera.WorldToScreenPoint(transform.position);
        //if (bulletPositionInScreenSpace.x > Screen.width)
        //{
        //    directionx *= -1;
        //}
        //if (bulletPositionInScreenSpace.x < 0)
        //{
        //    direction *= -1;
        //}

    }
}
