using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Color color;
    void Start()
    {
        Material material = new Material(Shader.Find(GameConfig.ShaderName));
        material.color =  color;

        GetComponent<Renderer>().material = material;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            
            Color playerColor = collision.gameObject.GetComponent<PlayerColors>().trueColor;

            if (color.IsEqualTo(playerColor))
            {
                Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
                rigidbody.useGravity = true;
                rigidbody.constraints = RigidbodyConstraints.None;
            }
            

        }
    }

}
