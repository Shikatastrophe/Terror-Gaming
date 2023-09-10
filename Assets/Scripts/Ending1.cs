using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending1 : MonoBehaviour, IInteractable
{
    public Animator animator;
    //public GameObject player;
    public GameManager gameManager;
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
        gameManager.End1();
    }
}
