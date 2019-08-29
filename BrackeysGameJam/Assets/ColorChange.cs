using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color trueColor;
    public Color visibleColor;
    void Start()
    {
        Material material = new Material(Shader.Find(GameConfig.ShaderName));
        material.color = visibleColor;

        GetComponent<Renderer>().material = material;
    }

}
