using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHourHand : MonoBehaviour
{
    public float rotationSpeed = 1f;



    // Update is called once per frame
    void Update()
    {

        {
            transform.Rotate(Vector2.right, rotationSpeed * Time.deltaTime);

        }


    }
        
    
}
