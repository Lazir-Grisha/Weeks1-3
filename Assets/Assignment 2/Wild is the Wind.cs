using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildistheWind : MonoBehaviour
{

    //to see if machine is on
    bool on = false;

    //code for spawning and frequency spawn
    public GameObject prefabToSpawn;
    public float spawnFrequency;
    private float timeSinceLastSpawn = 0f;

    //code for deleting object
    public GameObject spawnedObject = Instantiate(spawningprefab, spawnPosition, Quaternion.identify);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (on == true)
        {
            timeSinceLastSpawn += Time.deltaTime;
            Debug.Log(timeSinceLastSpawn.ToString());
            if (timeSinceLastSpawn > spawnFrequency)
            {
                Instantiate(prefabToSpawn);
                timeSinceLastSpawn = 0f;
            }
        }

        Destroy(spawnedObject, 2f);
    }
    public void OnClickGale()
    {
        //if statements to turn fan on and off with button pressed
        if (on == true)
        {
            on = false;
        }
        else if (on == false)
        {
            on = true;
        }
    }
}
