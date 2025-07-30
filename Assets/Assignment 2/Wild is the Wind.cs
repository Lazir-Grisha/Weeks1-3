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
    List<GameObject> spawnedObjects = new List<GameObject>();  //made a list checked it twice
    public float spawnFrequency;
    private float timeSinceLastSpawn = 0f;
    bool objectSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (on == true)
        {

            if (timeSinceLastSpawn > spawnFrequency && objectSpawned == false)
            {
                timeSinceLastSpawn = 0f;
                GameObject spawnedObject = Instantiate(prefabToSpawn);
                spawnedObjects.Add(spawnedObject);
                objectSpawned = true;
            }
            if (timeSinceLastSpawn > spawnFrequency && objectSpawned == true)
            {
                for (int i = 0; i < spawnedObjects.Count; i++)
                {
                    Destroy(spawnedObjects[i]);
                }
                spawnedObjects.Clear();
                objectSpawned = false;
            }
        } else if (on == false && objectSpawned == true)
            {
                for (int i = 0; i < spawnedObjects.Count; i++)
                {
                    Destroy(spawnedObjects[i]);
                }
                spawnedObjects.Clear();
                objectSpawned = false;
            }
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
