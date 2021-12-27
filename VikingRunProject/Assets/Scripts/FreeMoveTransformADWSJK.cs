using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMoveTransformADWSJK : MonoBehaviour
{
    MeshRenderer mr;
    public float movingSpeed = 10;
    float JumpingForce = 350;
    Rigidbody rb;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movingSpeed * Time.deltaTime);
            animator.SetBool("BeginRun",true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movingSpeed * Time.deltaTime);
            animator.SetBool("BeginRun", true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //transform.localPosition += movingSpeed * Time.deltaTime * this.transform.localEulerAngles;
                transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
                animator.SetBool("BeginRun", true);
            //Debug.Log(this.transform.localEulerAngles);
            //Debug.Log(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movingSpeed * Time.deltaTime);
            animator.SetBool("BeginRun", true);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.up;
            animator.SetBool("BeginRun", true);
        }
        if (Input.GetKeyDown(KeyCode.J) && (GlobalVariable.StartCounting == false && Physics.Raycast(transform.position,Vector3.down, 0.2f) ||  (GlobalVariable.StartCounting == true && Time.time - GlobalVariable.LastJump > 1.5)))
        {
                GetComponent<Rigidbody>().AddForce(JumpingForce * Vector3.up);
                GlobalVariable.LastJump = Time.time;
        }

    }
}
