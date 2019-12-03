
using System;
using UnityEngine;


[RequireComponent(typeof(SphereCollider))]
public class TurretControler : MonoBehaviour
{
    public string tagPlayer;
    public GameObject missilePrefab;
    //Faire une liste des points de départs des missiles
    
    private void OnTriggerEnter(Collider other)
    {
        //Si c'est le joueur, il faut que la tourelle pivote vers lui et tire six fois
    }
    
    
}
