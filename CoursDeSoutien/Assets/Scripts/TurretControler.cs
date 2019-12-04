
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
    
    //Quand le joueur entre dans le champ d'action de la tourelle, la tourelle se tourne vers le joueur et lui dire dessus. 
    //fonctions : transform.LookAt 
    /* instantiate (crée un objet) : un pour chaque trou (ce n'est pas sale). Prend un GameObject (prefab) et position dans laquelle il part + rotation. 
     * Instantiate (prefab, position, rotation). 
     *for (i = 0; i < 12; i++)
     */
}
