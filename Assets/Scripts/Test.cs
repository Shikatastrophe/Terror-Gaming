using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour,IInteractable
{
    public GameObject gm;
    public GameObject player;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Gaming()
    {
        Debug.Log("Gaming");
    }

    public void Interact()
    {
        animator.Play("FadeinUP");
        //gm.GetComponent<GlobalVariables>().AdvanceDay();
        StartCoroutine(Si());
    }

    public IEnumerator No()
    {
        yield return new WaitForSeconds(1f);
       
    }

    public IEnumerator Si()
    {
        yield return new WaitForSeconds(1.0f);
        player.GetComponent<FirstPersonController>().Respawn();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
