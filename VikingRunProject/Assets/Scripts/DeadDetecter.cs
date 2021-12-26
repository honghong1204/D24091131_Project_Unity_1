using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDetecter : MonoBehaviour
{
    public Transform Distance_ObjectA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Transform>().position.y < 0)
        {
            Debug.Log("Drop");
        }
        if(Vector3.Distance(this.GetComponent<Transform>().position, Distance_ObjectA.position) < 3)
        {
            Debug.Log("Caught");
        }
    }
}
