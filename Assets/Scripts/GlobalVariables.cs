using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public bool hasknife;
    public int day = 0;
    //sb == should be
    public GameObject sbactiveday1;
    public GameObject sbinactiveday1;
    public GameObject sbactiveday2;
    public GameObject sbactiveday3f1;
    public GameObject sbactiveday3f2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AdvanceDay()
    {
        day++;
    }

    // Update is called once per frame
    void Update()
    {
        switch (day) { 
        case 0:
            sbactiveday1.SetActive(true);
            sbinactiveday1.SetActive(true);
            break; 
        case 1:
            sbactiveday2.SetActive(true);
            break;
        case 2:
            if(hasknife)
                {
                    sbactiveday1.SetActive(false);
                    sbinactiveday1.SetActive(true);
                    sbactiveday2.SetActive(false);
                    sbactiveday3f2.SetActive(true);
                }
            else
                {
                    sbactiveday2.SetActive(false);
                    sbactiveday3f1.SetActive(true);
                }
            break;

        
        }
    }
}
