using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    private Animation run;
    public float speed = 0.5f;
    public float jumpForce = 0.5f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        bool isRunning = false;
        if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Time.deltaTime * transform.forward, 0);
            isRunning = true;
        }

        if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * Time.deltaTime * - transform.right, 0);
            isRunning = true;
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime * transform.right, 0);
            isRunning = true;
        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Time.deltaTime * - transform.forward, 0);
            isRunning = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        animator.SetBool("IsRunning", isRunning);
    }
}
