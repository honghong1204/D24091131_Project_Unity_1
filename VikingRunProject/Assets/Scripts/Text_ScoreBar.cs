using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Text_ScoreBar : MonoBehaviour
{
    private TMPro.TextMeshPro text;
    public Transform Distance_ObjectA;
    public Transform Distance_ObjectB;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMPro.TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Current Score: "+ GlobalVariable.curScore + "\n" + "Distance From Enemy: " + Vector3.Distance(Distance_ObjectA.position, Distance_ObjectB.position) + "\nPress ESC to Back To Menu";
    }
}
