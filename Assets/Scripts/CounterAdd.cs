using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterAdd : MonoBehaviour
{
    public GameObject gm;
    public void CounterUp()
    {
        gm.GetComponent<GlobalVariables>().AdvanceDay();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
