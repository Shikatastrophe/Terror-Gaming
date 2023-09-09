using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    public GameObject firstScene;
    public GameObject secondScene;

    public void ChangeScene()
    {
        //Debug.Log("Gaming");
        firstScene.SetActive(false);
        secondScene.SetActive(true);
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
