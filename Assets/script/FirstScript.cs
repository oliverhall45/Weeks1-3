using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += 1;

        if (pos.x < 0 || pos.x > 5)
        {
            speed = speed * -1;

        }
        transform.position = pos;
    }
}