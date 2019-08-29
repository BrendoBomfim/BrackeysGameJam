using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Color color;
    public float destroyHeight = -20f;

    void Start()
    {
        Material material = new Material(Shader.Find(GameConfig.ShaderName));
        material.color =  color;

        GetComponent<Renderer>().material = material;
    }

    private void FixedUpdate()
    {
       if(transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        } 
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
