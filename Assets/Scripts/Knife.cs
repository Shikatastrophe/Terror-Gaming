using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour, IInteractable
{
    public GameObject knife;
    public GameObject gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Interact()
    {
        knife.SetActive(false);
        gamemanager.GetComponent<GlobalVariables>().hasknife = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
