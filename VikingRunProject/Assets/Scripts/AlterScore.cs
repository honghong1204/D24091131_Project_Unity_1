using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterScore : MonoBehaviour
{
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        GlobalVariable.curScore += Score;
        Destroy(this.gameObject);
    }
}
