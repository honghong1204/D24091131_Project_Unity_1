using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadScoreTimeDisplayChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Score: " + GlobalVariable.curScore + "\nTime: " + GlobalVariable.curRunningTime + " secs";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
