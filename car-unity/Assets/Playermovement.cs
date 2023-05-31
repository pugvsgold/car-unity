using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
	public CharacterController controller;
	public Transform playerBody;
	
	public float speed = 12f;
	public float sense = 10f;


    void Update()
    {
    	float x = Input.GetAxis("Horizontal");
    	float z = Input.GetAxis("Vertical"); 
        
        Vector3 move = transform.forward * z * speed;
        
        controller.Move(move * speed * Time.deltaTime);
        //playerBody.Rotate(Vector3.forward * x * sense * Time.deltaTime);

    }
}
