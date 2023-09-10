using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject jumpscare;
    public GameObject enemy;
    public Camera cam;
    public LayerMask playerMask;
    public FirstPersonController firstPersonController;
    public Animator animator;
    public EnemyPatrolling ep;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Capsule") 
        {
            StartJumpscare();
        }
    }
    public void StartJumpscare()
    {
        jumpscare.SetActive(true);
        enemy.SetActive(false);
        
        StartCoroutine(Jjumpscare());
    }

    public IEnumerator Jjumpscare() 
    { 
        yield return new WaitForSeconds(1.9f);
        animator.Play("Fadein");
        yield return new WaitForSeconds(1.0f);
        jumpscare.SetActive(false);
        firstPersonController.Respawn();
        enemy.SetActive(true);
        ep.ResetEnemy();
        //enemy.transform.position = new Vector3(-27.17392f, 8.71f, 2.782705f);

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
