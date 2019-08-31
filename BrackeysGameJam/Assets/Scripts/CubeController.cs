using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Color color;
    public float destroyHeight = -20f;

    public Texture2D Tex;

    void Start()
    {
        Material material = new Material(Shader.Find(GameConfig.ShaderName));
        material.color =  color;
        material.mainTexture = Tex;
        GetComponent<Renderer>().material = material;
    }

    private void FixedUpdate()
    {
       if(transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        } 
    }

    private IEnumerator OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            
            Color playerColor = collision.gameObject.GetComponent<PlayerColors>().trueColor;

            if (color.IsEqualTo(playerColor))
            {
                yield return new WaitForSeconds(0.5f);
                Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
                rigidbody.useGravity = true;
                gameObject.GetComponent<Collider>().enabled = false;
                rigidbody.constraints = RigidbodyConstraints.None;

            }
            

        }
    }

}
