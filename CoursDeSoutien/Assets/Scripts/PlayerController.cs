using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))] //Ces trucs permettent de bloquer le fait qu'on aie besoin d'un Animator ET d'un Rigidbody pour mettre ce script sur un objet. 
public class PlayerController : MonoBehaviour //Classe : objet. Va pouvoir communiquer avec d'autres. MonoBehaviour : peut se répéter. 
{
    private Rigidbody rb;
    private Animator animator;

    private const float SPEED = 3f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
            
        if(Input.GetKey(KeyCode.Z))// On bouge vers l'avant
        {
            transform.Translate(SPEED*transform.forward*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))// On bouge à droite
        {
            transform.Translate(SPEED * transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))// On bouge vers la gauche
        {
            transform.Translate(SPEED * -transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))// On bouge vers l'arrière
        {
            transform.Translate(SPEED * -transform.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))// On bouge vers le haut
        {
            transform.Translate(3* SPEED * transform.up * Time.deltaTime);
        }
        //Faire bouger le joueur
        //Utiliser la bibliothèque Input
        //Appliquer une force sur le rigibody
    }
}
