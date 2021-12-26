using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountStartTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariable.StartCounting == true)
        {
            GlobalVariable.curRunningTime = Time.time - GlobalVariable.TimePassedBefore;
        }
    }
}
