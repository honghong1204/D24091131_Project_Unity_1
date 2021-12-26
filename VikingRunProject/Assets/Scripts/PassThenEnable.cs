using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThenEnable : MonoBehaviour
{
    public GameObject charToEnableForward1;
    public GameObject charToEnableForward2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GlobalVariable.StartCounting = true;
        GlobalVariable.TimePassedBefore = Time.time;
        charToEnableForward1.GetComponent<AutoMoveForward>().enabled = true;
        charToEnableForward2.GetComponent<AutoMoveForward>().enabled = true;
    }
}
