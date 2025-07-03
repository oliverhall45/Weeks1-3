using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMover : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        bool ifRightArrowIsPressed = Input.GetKey(KeyCode.RightArrow);
        Vector3 newRightPosition = transform.position + Vector3.right * 0.5f; 
        if (ifRightArrowIsPressed)
        {
            transform.position = newRightPosition;
        }
        bool ifLeftArrowIsPressed = Input.GetKey(KeyCode.LeftArrow);
        Vector3 newLeftPosition = transform.position + Vector3.right * 0.5f;
        if (ifLeftArrowIsPressed)
        {
            transform.position = newLeftPosition;
        }
        bool ifUpArrowIsPressed = Input.GetKey(KeyCode.UpArrow);
        Vector3 newUpPosition = transform.position + Vector3.right * 0.5f; 
        if (ifUpArrowIsPressed)
        {
            transform.position = newUpPosition;
        }
        bool ifDownArrowIsPressed = Input.GetKey(KeyCode.DownArrow);
        Vector3 newDownPosition = transform.position + Vector3.right * 0.5f;
        if (ifDownArrowIsPressed)
        {
            transform.position = newDownPosition;
        }

    }
}
