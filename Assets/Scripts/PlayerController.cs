using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(0,20)]
    [SerializeField]
    [Tooltip("velocidad max del coche")]
    private float speed=5f;
    
    [Range(0,90)]
    [SerializeField]
    [Tooltip("velocisdad maxima del coche")]
    private float turnSpeed=50f;

    private float HorizontalInput, verticalInput;
    
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        verticalInput= Input.GetAxis("Vertical");
        //Debug.Log("MOVIMIENTO HORIZONTAL: "+HorizontalInput);
        this.transform.Translate(speed*Time.deltaTime*Vector3.forward*verticalInput);
        this.transform.Rotate(turnSpeed*Time.deltaTime*Vector3.up*HorizontalInput);
        
    }  
}

