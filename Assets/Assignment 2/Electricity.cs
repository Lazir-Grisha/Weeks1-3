using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Electricity : MonoBehaviour
{
    //variables governing the power slider
    public Slider powerSlider;
    public float maxPower = 1;
    public float minimumPower = 0;
    public float currentPower;

    ////variables governing power generation
    public float generate;
    bool on = false;
    private float timeSinceLastGenerate = 0f;
    public float generateFrequency;
    public int fanSpeed;
    public Slider speedSlider;
    public int maxSpeed = 1;
    public int minSpeed = 0;
    public float currentSpeed;


    public WindyDay windyDay;
    public Zeusian zeusian;


    ////variables governing usage of energy
    private float timeSinceLastUse = 0f;
    public float useFrequency;
    public float usage;
    bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        //start at 50 power
        currentPower = 50f;
        powerSlider.value = currentPower/maxPower;
        speedSlider.value = currentSpeed / maxSpeed;
        //Random.Range was found at https://docs.unity3d.com/ScriptReference/Random.Range.html
        useFrequency = Random.Range(1f, 5f);
        generateFrequency = Random.Range(1f, 5f);
        gameStart = false;
    }

    // Update is called once per frame
    void Update()
    {

        //electricity starts changing when the game starts
        if (gameStart == true)
        {
            //everytime timeSinceLastUse is greater than the usage frequency usage equals a random number between 1 - 20 and then reset timesince and use Frequency
            timeSinceLastUse += Time.deltaTime;
           // Debug.Log(timeSinceLastUse.ToString());

            if (timeSinceLastUse >= useFrequency)
            {
                usage = Random.Range(1f, 20f);
                Debug.Log("Usage[" + usage.ToString() + "]");
                timeSinceLastUse = 0f;
                useFrequency = Random.Range(1f, 5f);
                currentPower -= usage;
                powerSlider.value = currentPower / maxPower;
            }
            if (on == true)
            {
                timeSinceLastGenerate += Time.deltaTime;
               // Debug.Log(timeSinceLastGenerate.ToString());

                if (timeSinceLastGenerate >= generateFrequency && fanSpeed == 1)
                {
                    generate = Random.Range(1f, 10f);
                    Debug.Log("Generate[" + generate.ToString() + "]");
                    timeSinceLastGenerate = 0f;
                    generateFrequency = Random.Range(1f, 6f);
                    currentPower += generate;
                    powerSlider.value = currentPower / maxPower;
                }
                else if (timeSinceLastGenerate >= generateFrequency && fanSpeed == 2)
                {
                    generate = Random.Range(2f, 12f);
                    Debug.Log("Generate[" + generate.ToString() + "]");
                    timeSinceLastGenerate = 0f;
                    generateFrequency = Random.Range(1f, 5f);
                    currentPower += generate;
                    powerSlider.value = currentPower / maxPower;
                }
                else if (timeSinceLastGenerate >= generateFrequency && fanSpeed == 3)
                {
                    generate = Random.Range(4f, 20f);
                    Debug.Log("Generate[" + generate.ToString() + "]");
                    timeSinceLastGenerate = 0f;
                    generateFrequency = Random.Range(1f, 3f);
                    currentPower += generate;
                    powerSlider.value = currentPower / maxPower;
                }
            }


            //if the current Power exceeds the maxPower turn the machine off and set the current power to 0f.
            if (currentPower >= maxPower)
            {
                on = false;
                currentPower = minimumPower;
            }
            if (currentPower <= minimumPower)
            { 
                on = false;
            currentPower = minimumPower;
        }

            //update the current power

        }
    }
    public void OnClickOn()
    {
        gameStart = true;
        if (on == false)
        {
            on = true;
            if (currentPower >= 20f)
            {
                currentPower += -10f;
            } else if (currentPower <= 20f)
            {
                currentPower = 50f;
            }
        }
        else if (on == true)
        {
            on = false;
        }
    }
    public void OnPowerChanged()
    {
        //Debug.Log("Power has changed + " + powerSlider.value.ToString());
    }

    public void OnSpeedChanged()
    {
        currentSpeed = speedSlider.value * maxSpeed;
        if (currentSpeed <= 33)
        {
            fanSpeed = 1;
                } else if (currentSpeed >= 33 && currentSpeed <= 66)
        {
            fanSpeed = 2;
        } else if (currentSpeed >= 66)
        {
            fanSpeed = 3;
        }

    }
}

