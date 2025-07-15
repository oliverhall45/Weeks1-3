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
            cannonballRenderer.color = cannonballColour;

            Cannonball cannonballScript = spawnedCannonball.GetComponent <Cannonball>();
            cannonballScript.moveDuration = cannonballMoveDuration;
        }
    }
}
