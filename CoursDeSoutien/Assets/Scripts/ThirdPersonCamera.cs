﻿using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public GameObject target;
    public GameObject camerafixpoint;
    public float rotateSpeed = 5;
    private Vector3 offset;
     
    private void Start() {
        offset = target.transform.position - transform.position;
    }
     
    private void LateUpdate() {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.rotation *= Quaternion.Euler(0, horizontal, 0); //Le Quaternion d'Euler sert à ne pas mettre le h. 
 
        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);
         
        transform.LookAt(camerafixpoint.transform);
    }
}
