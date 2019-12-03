using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    public float speed;
    public float rotationSpeed = 200.0f;
    private float moveHorizontal;
    private float moveVertical;
    private Vector3 movement;
    
    private Vector3 newRotation;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        bool isRunning = false;
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(speed * Time.deltaTime * transform.forward,0);
            isRunning = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-speed * Time.deltaTime* transform.forward,0);
            isRunning = true;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-speed * Time.deltaTime* transform.right,0);
            isRunning = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime* transform.right,0);
            isRunning = true;
        }
        animator.SetBool("IsRunning", isRunning);
    }
}
