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
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        bool isRunning = false;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Time.deltaTime * transform.forward,0);
            isRunning = true;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Time.deltaTime * -transform.forward,0);
            isRunning = true;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime * transform.right,0);
            isRunning = true;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * Time.deltaTime * -transform.right,0);
            isRunning = true;
        }
        animator.SetBool("isrunning",isRunning);
        //Faire bouger le joueur
        //Utiliser la bibliothèque Input
        //Appliquer une force sur le rigibody
    }
}
