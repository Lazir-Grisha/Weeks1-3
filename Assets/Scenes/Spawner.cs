using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Vector3 spawnPoint;
    List<GameObject> spawnedObjects = new List<GameObject>();
    //List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        //spawnedObjects { }

        //GameObject spawnedObject = Instantiate(prefabToSpawn);
        //spawnedObjects.Add(spawnedObject);

        ////spawnedObjects { spawnedObject[0] }

        //GameObject spawnedObject2 = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        //spawnedObjects.Add(spawnedObject2);

        //Destroy(spawnedObjects[0]);

        //DONT DO THIS!!! The prefab is not to be touched >:(
        //Destroy(prefabToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn);
            spawnedObjects.Add(spawnedObject);
        }

        if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < spawnedObjects.Count; i++)
            {
                Destroy(spawnedObjects[i]);
            }
            spawnedObjects.Clear();
        }
    }
}

