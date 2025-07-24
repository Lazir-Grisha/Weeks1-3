using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public float cannonballMoveDuration;
    public Color cannonballColour;

    // Start is called before the first frame update
    void Start()
    {
        Cannonball test = gameObject.GetComponent<Cannonball>();
        Debug.Log(test);
    }

    // Update is called once per frame
    void Update()
    {
        bool leftClick = Input.GetMouseButtonDown(0);

        if (leftClick)
        {
            GameObject spawnedCannonball = Instantiate(cannonballPrefab, transform.position, Quaternion.identity);
            Debug.Log(spawnedCannonball.name);
            SpriteRenderer cannonballRenderer = spawnedCannonball.GetComponent<SpriteRenderer>();

            //If we have successfully found a renderer, then we can do stuff with it
            if (cannonballRenderer != null)
            {
                cannonballRenderer.color = cannonballColour;
            }
            else
            {
                //Otherwise don't do stuff with the renderer or else ERRORS!!
            }

            //set the speed? what has the speed?
            Cannonball cannonballScript = spawnedCannonball.GetComponent<Cannonball>();
            if (cannonballScript == null)
            {
                Debug.Log("Cannonball script could not be found.");
            }
            else
            {
                cannonballScript.moveDuration = cannonballMoveDuration;
            }

        }
    }
}