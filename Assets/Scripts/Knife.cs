using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour, IInteractable
{
    public bool day1;
    public GameObject knife;
    public GameObject gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Interact()
    {
        if(day1 == true)
        {
            gamemanager.GetComponent<GlobalVariables>().hasknifeday1 = true;
            Destroy(knife);
        }
        else
        {
            gamemanager.GetComponent<GlobalVariables>().hasknifeday2 = true;
            Destroy(knife);
        }
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
