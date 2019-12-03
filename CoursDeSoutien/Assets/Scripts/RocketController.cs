using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RocketController : MonoBehaviour
{
    private Rigidbody rb;
    private const float FORCE_VALUE = 2f;
    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Turret"))
        {
            if (other.CompareTag("Player"))
            {
                Destroy(other.gameObject);
            }

            Destroy(gameObject);
        }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(FORCE_VALUE*transform.forward, ForceMode.Impulse);
    }
}
