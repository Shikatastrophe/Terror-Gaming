using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour, IInteractable
{
    public Animator animator;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Interact()
    {
        animator.Play("Fadein");
        StartCoroutine(Si());
    }

    public IEnumerator Si()
    {
        yield return new WaitForSeconds(1.0f);
        player.GetComponent<FirstPersonController>().Respawn();
    }
}
