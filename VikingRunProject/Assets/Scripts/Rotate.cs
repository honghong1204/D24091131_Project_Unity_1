using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.Rotate(0,-90,0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            transform.Rotate(0, -30, 0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            transform.Rotate(0, 30, 0);
        }
    }
}
