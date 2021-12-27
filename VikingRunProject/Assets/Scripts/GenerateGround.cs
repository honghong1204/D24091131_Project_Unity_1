using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class GenerateGround : MonoBehaviour
{
    //public List<Transform> Grounds;

    public Transform Ground0;
    public Transform Ground0_90;
    public Transform Ground1;
    public Transform Ground1_90;
    public Transform Ground2;
    public Transform Ground2_90;
    public Transform Ground3;
    public Transform Ground3_90;
    public Transform Ground4;
    public Transform Ground4_90;
    public Transform Ground5;
    public Transform Ground5_90;
    public Transform GroundHalf;
    public Transform GroundHalf_90;
    public Transform NoFence;
    private bool passed = false;
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalVariable.GeneratedCount == 0)
        {
            GlobalVariable.curGeneratedLoc = new Vector3(-76.88f,16.56f,-19.8f);
            GlobalVariable.GroundList0.Add(Ground0);
            GlobalVariable.GroundList0.Add(Ground1);
            GlobalVariable.GroundList0.Add(Ground2);
            GlobalVariable.GroundList0.Add(Ground3);
            GlobalVariable.GroundList0.Add(Ground4);
            GlobalVariable.GroundList0.Add(Ground5);
            GlobalVariable.GroundList0.Add(GroundHalf);
            GlobalVariable.GroundList90.Add(Ground0_90);
            GlobalVariable.GroundList90.Add(Ground1_90);
            GlobalVariable.GroundList90.Add(Ground2_90);
            GlobalVariable.GroundList90.Add(Ground3_90);
            GlobalVariable.GroundList90.Add(Ground4_90);
            GlobalVariable.GroundList90.Add(Ground5_90);
            GlobalVariable.GroundList90.Add(GroundHalf_90);


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
            if(GlobalVariable.GeneratedCount < 6)
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
                    Transform curGeneratedGround = Instantiate(pickAGround(GlobalVariable.GroundList0), null);
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
                    Debug.Log("C" + GlobalVariable.justGenerated);
                    Transform curJunction = Instantiate(NoFence, null);
                    curJunction.position = GlobalVariable.curGeneratedLoc + new Vector3(-7, 0, -7);
                    Transform curGeneratedGround = Instantiate(Ground0_90, null);
                    curGeneratedGround.position = curJunction.position + new Vector3(0, 0, -7);
                    passed = true;
                    GlobalVariable.justGenerated = 90;
                    GlobalVariable.curGeneratedLoc = curGeneratedGround.position;
                    GlobalVariable.GeneratedCount += 1;
                }
                else
                {
                    Debug.Log("D" + GlobalVariable.justGenerated);
                    Transform curGeneratedGround = Instantiate(pickAGround(GlobalVariable.GroundList90), null);
                    curGeneratedGround.position = GlobalVariable.curGeneratedLoc + new Vector3(0, 0, -7);
                    passed = true;
                    GlobalVariable.justGenerated = 90;
                    GlobalVariable.curGeneratedLoc = curGeneratedGround.position;
                    GlobalVariable.GeneratedCount += 1;
                }

            }
        }

    }
    public Transform pickAGround(List<Transform> curGround)
    {
        int A = Random.Range(0, curGround.Count);
        Debug.Log(curGround.Count);
        Debug.Log(A);
        return curGround[A];
        }
}

