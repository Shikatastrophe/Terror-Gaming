using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTurnOn : MonoBehaviour
{
    public GameObject Dialogue;
    public Dialoge DialogeScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogeScript.isTalking)
        {
            Dialogue.SetActive(true);
        }
        else
        {
            Dialogue.SetActive(false);
        }
    }
}
