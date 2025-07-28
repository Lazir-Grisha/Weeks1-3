using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricity : MonoBehaviour
{
    //variables governing the power slider
    public Slider powerSlider;
    public float maxPower = 100;
    public float minimumPower;
    private float currentPower;

    //variables governing power generation
    public float generate;
    bool on = false;
    private float timeSinceLastGenerate = 0f;
    public float generateFrequency;


    //variables governing usage of energy
    private float timeSinceLastUse = 0f;
    public float useFrequency;
    public float usage;
    bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        //start at 50 powers
        currentPower = 50f;
        powerSlider.value = currentPower/maxPower;
        useFrequency = random.range(1f, 5f);
        generateFrequency = random.range(1f, 5f);
        gameStart = false;
    }

    // Update is called once per frame
    void Update()
    {

        //electricity starts changing when the game starts
        if (gameStart == true)
        {
            //everytime timeSinceLastUse is greater than the usage frequency usage equals a random number between 1-20 and then reset timesince and use Frequency
            timeSinceLastUse += Time.deltaTime;
            Debug.Log(timeSinceLastUse.ToString());
            if (timeSinceLastUse > useFrequency)
            {
                usage = random.range(1f, 20f);
                timeSinceLastSpawn = 0f;
                useFrequency = random.range(1f, 5f);
            }

            timeSinceLastGenerate += Time.deltaTime;
            Debug.Log(timeSinceLastGenerate.ToString());
            if (timeSinceLastGenerate > generateFrequency)
            {
                generate = random.range(1f, 20f);
                timeSinceLastGenerate = 0f;
                generateFrequency = random.range(1f, 5f);
            }


            //update the current power
            currentPower += generate - usage;
            powerSlider.value = currentPower / maxPower;
        }
    }
    public void OnClickOn()
    {
        gameStart = true;
        if (on == false) {
            on = true;
            currentPower += -10f;
        } else if (on == true)
        {
            on = false;
        }
    }
}

