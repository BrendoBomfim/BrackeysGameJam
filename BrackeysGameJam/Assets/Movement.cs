using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(0,20)]
    public float moveSpeed = 10f;
    private Vector3 moveDirection;

    public Transform Camera;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {

        moveDirection = -Camera.forward * Input.GetAxis("Horizontal")
        + Camera.right * Input.GetAxis("Vertical");
        moveDirection.y = 0;

        Debug.DrawRay(transform.position, transform.position + moveDirection);
        transform.Translate(moveDirection.normalized * Time.deltaTime * moveSpeed);
    }
}
