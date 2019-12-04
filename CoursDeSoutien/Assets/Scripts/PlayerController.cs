using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private const float SPEED = 3;
    private Rigidbody rb;
    private Animator animator;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        bool isRunning = false;
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(SPEED * Time.deltaTime * transform.forward,0);
            isRunning = true;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-SPEED * Time.deltaTime * transform.forward,0);
            isRunning = true;
        }
        
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-SPEED * Time.deltaTime * transform.right,0);
            isRunning = true;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(SPEED * Time.deltaTime * transform.right,0);
            isRunning = true;
        }
        animator.SetBool("IsRunning", isRunning);
    }
}
