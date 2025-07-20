using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Vector3 spawnPoint;
    List<GameObject> spawnedObjects = new List<GameObject>();

    public Camera gameCamera;

    private float timeSinceLastSpawn = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //moves the barrel
        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;

        Vector3 start = transform.position;
        Vector3 end = mousePositionInWorldSpace;

        Vector3 direction = end - start;

        transform.up = direction;

        //spawn bullet

        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn);
            spawnedObjects.Add(spawnedObject);
            timeSinceLastSpawn += Time.deltaTime;
            Debug.Log(timeSinceLastSpawn.ToString());

        }
        if (timeSinceLastSpawn >= 5)
        {
            for (int i = 0; i < spawnedObjects.Count; i++)
            {
                Destroy(spawnedObjects[i]);
            }
            spawnedObjects.Clear();
        }
    }
}
