using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Center : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public Transform center;
    void Update()
    {
        GetComponent<Rigidbody>().centerOfMass = center.localPosition;
    }
}

