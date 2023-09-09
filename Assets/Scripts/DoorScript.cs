using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour, IInteractable
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Interact()
    {
        animator.Play("Fadein");
    }
}
