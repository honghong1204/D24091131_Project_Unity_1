using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMoveTransformADWSJK : MonoBehaviour
{
    MeshRenderer mr;
    float movingSpeed = 15f;
    float JumpingForce = 30;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movingSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movingSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //transform.localPosition += movingSpeed * Time.deltaTime * this.transform.localEulerAngles;
            transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
            //Debug.Log(this.transform.localEulerAngles);
            //Debug.Log(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movingSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.up;
        }
        if (Input.GetKey(KeyCode.J) )
        {
         Debug.Log(transform.position.y);
            if( transform.position.y <= 17.5)
            {
                GetComponent<Rigidbody>().AddForce(JumpingForce * Vector3.up);
            }
        }

    }
}
