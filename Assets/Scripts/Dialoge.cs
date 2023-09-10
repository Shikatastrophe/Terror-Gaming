using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialoge : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public Button button;
    public bool isTalking;
    public AudioSource audioSource;
    public GameObject dialogueboxfull;
    public GameObject endBox;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        button.onClick.AddListener(taskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        isTalking = true;

    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            audioSource.Play();
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogueboxfull.SetActive(false);
            endBox.SetActive(true);
            StartCoroutine(QuitGame());
            //gameObject.SetActive(false);
            
        }
    }

    public IEnumerator QuitGame()
    {
        yield return new WaitForSeconds(10f);
        Debug.Log("salir app");
        Application.Quit();
    }

    void taskOnClick()
    {

        if (textComponent.text == lines[index])
        {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            textComponent.text = lines[index];
            
        }

    }
}
