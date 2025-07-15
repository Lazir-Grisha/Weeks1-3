using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HourHand : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed;
        transform.eulerAngles = newRotation;
    }
}
