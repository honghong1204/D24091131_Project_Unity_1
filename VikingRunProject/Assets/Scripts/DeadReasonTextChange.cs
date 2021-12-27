using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadReasonTextChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalVariable.DeadReason == 1)
        {
            GetComponent<Text>().text = "FALLEN";
        }
        else if(GlobalVariable.DeadReason == 2)
                {
            GetComponent<Text>().text = "ENEMY CAUGHT YOU";
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
