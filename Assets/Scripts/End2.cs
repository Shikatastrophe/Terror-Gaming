using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End2 : MonoBehaviour
{
    public GameManager gameManager;
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Capsule")
        {
            animator.Play("Fadein");
            StartCoroutine(Si());
        }
    }

    public IEnumerator Si()
    {
        yield return new WaitForSeconds(1.0f);
        gameManager.End2();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
