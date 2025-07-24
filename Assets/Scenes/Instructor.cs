using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructor : MonoBehaviour
{
    public float startValue;
    public float endValue;

    public float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float output = Mathf.Lerp(startValue, endValue, currentTime);
        //If currentTime = 0 : Lerp will give us the startValue
        //In this case that's 0

        //If currentTime = 0.25 : 
        //In this case it's 25

        //If currentTime = 0.5 : Lerp gives us halfway between startValue and endValue
        //In this case it's 50

        //If currentTime = 1 : Lerp will give us the endValue
        //In this case that's 100


        Debug.Log(output.ToString());
    }
}
