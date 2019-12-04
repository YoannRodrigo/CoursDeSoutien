using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))] // si le script n'a pas ses composants, il les recrée ou vous empêche de les supprimer
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    private const float VITESSE = 4;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        bool isRunning = false; 
        //Faire bouger le joueur
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(VITESSE * transform.forward * Time.deltaTime, 0);
            isRunning = true;
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(VITESSE * -transform.forward * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(VITESSE * -transform.right * Time.deltaTime, 0);
        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(VITESSE * transform.right * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Space))
        {
            transform.Translate(VITESSE * transform.up * Time.deltaTime, 0);
        }
        animator.SetBool("IsRunning", isRunning);
    }
}
