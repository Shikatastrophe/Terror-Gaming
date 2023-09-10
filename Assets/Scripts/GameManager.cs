using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Playground");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void End1()
    {
        SceneManager.LoadScene("End1");
    }

    public void End2()
    {
        SceneManager.LoadScene("End2");
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
