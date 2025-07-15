using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructor : MonoBehaviour
{
    public float startValue;
    public float endValue;

    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float output = Mathf.Lerp(startValue, endValue, currentTime);
        //if currentTime = 0 : Lerp will give us the startValue
            //in this case thats 100

        //if currentTime = 0.5 : Lerp gives us halfway between startValue and endValue
            //in this case its 50

        //if currentTime = 1 : Lerp will give us the endValue
            //in this case thats 0

        Debug.Log(output.ToString());
    }
}
