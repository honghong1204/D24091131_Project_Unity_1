using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class GenerateGround : MonoBehaviour
{
    //public List<Transform> Grounds;
    public Transform Ground0;
    public Transform Ground90;
    public Transform NoFence;
    private bool passed = false;
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalVariable.GeneratedCount == 0)
        {
            Debug.Log(transform.localPosition);
            GlobalVariable.curGeneratedLoc = new Vector3(-76.88f,16.56f,-19.8f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (passed == false)
        {
            int curGen = Random.Range(0, 10);
            if(GlobalVariable.GeneratedCount < 5)
            {
                curGen = 1;
            }
            //Debug.Log(Grounds[Grounds.Count - 1].position);
            if (curGen < 5)
            {  // slightly right
                if (GlobalVariable.justGenerated != 0)
                {
                    Debug.Log("A" + GlobalVariable.justGenerated);
                    Transform curJunction = Instantiate(NoFence, null);
                    curJunction.position = GlobalVariable.curGeneratedLoc + new Vector3(-7,0, -7);
                    Transform curGeneratedGround = Instantiate(Ground0, null);
                    curGeneratedGround.position = curJunction.position + new Vector3(-7, 0, 0);
                    passed = true;
                    GlobalVariable.justGenerated = 0;
                    GlobalVariable.curGeneratedLoc = curGeneratedGround.position;
                    GlobalVariable.GeneratedCount += 1;
                }
                else
                {
                    Debug.Log("B" + GlobalVariable.justGenerated);
                    Transform curGeneratedGround = Instantiate(Ground0, null);
                    curGeneratedGround.position = GlobalVariable.curGeneratedLoc + new Vector3(-7, 0, 0f);
                    passed = true;
                    GlobalVariable.justGenerated = 0;
                    GlobalVariable.curGeneratedLoc = curGeneratedGround.position;
                    GlobalVariable.GeneratedCount += 1;
                }
            }
            else if (curGen < 10)
            {  // slightly left
                if (GlobalVariable.justGenerated != 90)
                {
                    Debug.Log("C"+ GlobalVariable.justGenerated);
                    Transform curJunction = Instantiate(NoFence, null);
                    curJunction.position = GlobalVariable.curGeneratedLoc + new Vector3(-7, 0, -7);
                    Transform curGeneratedGround = Instantiate(Ground90, null);
                    curGeneratedGround.position = curJunction.position + new Vector3(0, 0, -7);
                    passed = true;
                    GlobalVariable.justGenerated = 90;
                    GlobalVariable.curGeneratedLoc = curGeneratedGround.position;
                    GlobalVariable.GeneratedCount += 1;
                }
                else
                {
                    Debug.Log("D" + GlobalVariable.justGenerated);
                    Transform curGeneratedGround = Instantiate(Ground90, null);
                    curGeneratedGround.position = GlobalVariable.curGeneratedLoc + new Vector3(0, 0, -7);
                    passed = true;
                    GlobalVariable.justGenerated = 90;
                    GlobalVariable.curGeneratedLoc = curGeneratedGround.position;
                    GlobalVariable.GeneratedCount += 1;
                }

            }
        }
    }
}
