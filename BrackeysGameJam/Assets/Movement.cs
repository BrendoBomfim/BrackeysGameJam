using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10f;
        moveDirection = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        
        transform.Translate(moveDirection * Time.deltaTime * moveSpeed);
    }
}
