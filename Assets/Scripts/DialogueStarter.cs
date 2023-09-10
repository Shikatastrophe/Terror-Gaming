using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class DialogueStarter : MonoBehaviour
{
    private BoxCollider bc;
    public DialogueTrigger dt;
    public string functionName;
    
    private void Start()
    {
        bc = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            // get the type of the DialogueTrigger script
            Type dtType = dt.GetType();
            // get the method info of the function by name
            MethodInfo dtMethod = dtType.GetMethod(functionName);
            // invoke the function with no parameters
            dtMethod.Invoke(dt, null);
            Destroy(bc);
        }
    }
}
