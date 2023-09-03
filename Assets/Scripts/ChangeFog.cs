using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFog : MonoBehaviour
{
    public Color newColor;
    void Start()
    {
        // Set the fog color to be blue
        RenderSettings.fogColor = newColor;

        // And enable fog
        RenderSettings.fog = true;
    }
}
