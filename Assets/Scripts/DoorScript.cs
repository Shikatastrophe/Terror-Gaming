using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour, IInteractable
{
    public Animator animator;
    public GameObject player;
    public Jumpscare jumpscare;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Interact()
    {
        jumpscare.StartJumpscare();
       
        StartCoroutine(Si());
    }

    public IEnumerator Si()
    {
        yield return new WaitForSeconds(1.9f);
        animator.Play("FadeinUP");
        yield return new WaitForSeconds(1.0f);
        player.GetComponent<FirstPersonController>().Respawn();
    }
}
