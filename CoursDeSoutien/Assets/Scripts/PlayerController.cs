using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))] //créer le component sur l'objet à qui on applique le script et empêche le delete de ce component
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;

    private const float SPEED = 3;
    private int entierPrivate;
    protected int entierProtected;//variable disponible seulement pour les enfants de la class

    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame, Fixed Update, LateUpdate
    private void Update()
    {
        if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(SPEED * transform.forward * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(SPEED * -transform.forward * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(SPEED * -transform.right * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(SPEED * transform.right * Time.deltaTime);
        }
        //Faire bouger le joueur
        //Utiliser la bibliothèque Input
        //Appliquer une force sur le rigibody
    }
}
