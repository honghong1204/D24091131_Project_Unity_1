using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    public Transform ToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Transform>().LookAt(ToFollow);
    }
}
