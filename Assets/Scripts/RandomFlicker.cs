using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFlicker : MonoBehaviour
{
    public Animator animator;
    //public Animator animator2;
    int rng;
    // Start is called before the first frame update
    void Start()
    {
        
        rng = Random.Range(0, 3);
        //Debug.Log(rng);

        switch (rng)
        {
            case 0:
                animator.Play("Flicker");
                //animator2.Play("Flicker");
                break;
            case 1:
                animator.Play("Flicker2");
                //animator2.Play("Flicker2");
                break;
            case 2:
                animator.Play("Flicker3");
                //animator2.Play("Flicker3");
                break;
            case 3:
                animator.Play("Flicker4");
                //animator2.Play("Flicker4");
                break;
        }
    }
}
