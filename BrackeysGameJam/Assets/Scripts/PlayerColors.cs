using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColors : MonoBehaviour
{
    public Color trueColor;
    public Color visibleColor;

    private Material material;


    public List<Renderer> Renders = new List<Renderer> { };

    void Start()
    {
       
        Material material = new Material(Shader.Find(GameConfig.ShaderName));
        material.color = visibleColor;

        foreach(var r in Renders)
        {
            r.material = material;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "newColor")
        {
            trueColor = collider.gameObject.GetComponent<ColorChange>().trueColor;
            visibleColor = collider.gameObject.GetComponent<ColorChange>().visibleColor;

            //material.color = visibleColor;

            //GetComponent<Renderer>().material = material;

            foreach (var r in Renders)
            {
                r.material.color = visibleColor;
            }
        }
    }
}
