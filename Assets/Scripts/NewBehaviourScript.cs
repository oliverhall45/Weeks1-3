using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject fireballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawnedObject;

            //Instantiate returns the copied GameObject tjat we make using the prefab
            spawnedObject = Instantiate(fireballPrefab, transform.position, transform.rotation, transform);

            //We use GetComponent to get access to the Transform component off of the spawned object 
            Transform spawnedTransform = spawnedObject.GetComponent<Transform>();

            //We can set the parent of the spawnedTransform using SetParent
            spawnedTransform.transform.SetParent(transform);

            //We can remove the parent of the spawnedTransform by setting parent as equal to null
            spawnedTransform.parent = null;
        }
    }
}
