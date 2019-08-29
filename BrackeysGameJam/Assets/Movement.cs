using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(0,1000)]
    public float moveSpeed = 200f;

    public Animator Animator;

    private Vector3 moveDirection;

    private Transform CameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3();

        CameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.position + moveDirection);

        moveDirection = CameraTransform.right * Input.GetAxis("Horizontal")
        + CameraTransform.forward * Input.GetAxis("Vertical");
        moveDirection.y = 0;


        if (moveDirection.magnitude > 0.1f)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);

            var y = GetComponent<Rigidbody>().velocity.y;
            var dir = moveDirection * Time.deltaTime * moveSpeed;
            dir.y = y;
            GetComponent<Rigidbody>().velocity = dir;


          
        }

        //tint
        //var tint = transform.eulerAngles;
        //if (GetComponent<Rigidbody>().velocity.magnitude > 0.1f)
        //{
        //    tint.x -= Time.deltaTime;
        //    tint.x = Mathf.Clamp(tint.x, -10, 0);
        //    transform.eulerAngles = tint;
        //}
        //else if (tint.x < 0)
        //{

        //    tint.x += Time.deltaTime;

        //}
        //transform.eulerAngles = tint;


        Animator.SetFloat("Speed", GetComponent<Rigidbody>().velocity.magnitude );

    }
}
