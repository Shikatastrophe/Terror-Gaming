using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialoge : MonoBehaviour
{
    public bool isTalking;
    public TextMeshProUGUI text;
    private string line;
    public float textspeed;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        dialogue1(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dialogue1()
    {
        line = "You need to escape from here, try to look for a way out";
        startdialogue();
    }

    public void dialogue2()
    {
        line = "You can use that knife, make sure to hide it";
        startdialogue();
    }

    public void dialogue3()
    {
        line = "Shh, be quiet! She'll get you if she hears you...";
        startdialogue();
    }

    public void dialogue4()
    {
        line = "Remember to grab it, it should be in the kitchen";
        startdialogue();
    }

    void startdialogue()
    {
        StopAllCoroutines();
        isTalking = true;
        text.text = "";
        StartCoroutine(typeline());
    }

    public IEnumerator typeline()
    {
        foreach (char c in line)
        {
            text.text += c;
            audioSource.Play();
            yield return new WaitForSeconds(textspeed);
        }
        yield return new WaitForSeconds(3);
        isTalking=false;
    }
}
