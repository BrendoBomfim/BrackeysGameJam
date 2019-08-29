using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColors : MonoBehaviour
{
    public Color trueColor;
    public Color visibleColor;

    void Start()
    {
        Material material = new Material(Shader.Find("Unlit/Color"));
        material.color = visibleColor;

        GetComponent<Renderer>().material = material;
    }
}
