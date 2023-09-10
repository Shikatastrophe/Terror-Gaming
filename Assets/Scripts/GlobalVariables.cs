using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public bool hasknifeday1;
    public bool hasknifeday2;
    public int day = 0;
    //sb == should be
    public GameObject sbactiveday1;
    public GameObject sbinactiveday1;
    public GameObject knifeday1;
    public GameObject sbactiveday2;
    public GameObject knifeday2;
    public GameObject sbactiveday3f1;
    public GameObject sbactiveday3f2;
    public GameObject test;
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
                test.SetActive(false);
                sbactiveday1.SetActive(true);
            sbinactiveday1.SetActive(false);
            if (knifeday1 != null)
            {
                knifeday1.SetActive(true);
            }
            break; 
        case 1:
                sbactiveday1.SetActive (false);
                test.SetActive (true);
                if (hasknifeday1)
                {
                    sbactiveday2.SetActive(true);
                    if(knifeday2 != null)
                    {
                        knifeday2.SetActive(true);
                    }
                }
                else
                {
                    knifeday1.SetActive(false);
                    sbactiveday2.SetActive(true);
                }
            break;
        case 2:
                test.SetActive(false);
            if(hasknifeday2)
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
