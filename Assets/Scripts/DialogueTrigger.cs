using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public bool isTalking;
    public TextMeshProUGUI text;
    private string line;
    public float textspeed;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    public class Dialoge : MonoBehaviour
    {

    }

    //day1

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
        line = "He is probably in his office, but we don't need to go there";
        
        startdialogue();
    }

    public void dialogue4()
    {
        line = "Look around, we might find something useful";

        startdialogue();
    }

    public void dialogue5()
    {
        line = "The exit should be around the corner";

        startdialogue();
    }

    //day2

    public void dialogue6()
    {
        line = "They tightened security, you can look around, but you can't escape today";
        startdialogue();
    }

    public void dialogue7()
    {
        line = "Shh, be careful! She'll get you if she sees you...";
        startdialogue();
    }
    public void dialogue8()
    {
        line = "Remember to grab it, it should be in the kitchen";
        startdialogue();
    }

    public void dialogue9()
    {
        line = "They won't let you go that easily, better go to bed for the day.";
        startdialogue();
    }

    //day3end1

    public void dialogue10()
    {
        line = "This will be your only chance, go for the exit, NOW";
        startdialogue();
    }

    public void dialogue11()
    {
        line = "Freedom, at last!";
        startdialogue();
    }

    //day3end2

    public void dialogue12()
    {
        line = "They caught you misbehaving, it's time for revenge...";
        startdialogue();
    }

    public void dialogue13()
    {
        line = "Don't be scared, I'm with you...";
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
        isTalking = false;
    }
}
