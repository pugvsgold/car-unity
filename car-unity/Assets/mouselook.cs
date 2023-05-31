using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
	public float mouseSensitivity = 100f;
	public float xRotation = 0f;
	public float move = 0f;
	public float rsens = 1f;
	public float val = 1f;
	
	public Transform playerBody;
	//public Transform cambd;
	public float hrot = 0f;
    // Start is called before the first frame update
    void Start()
    {
     	Cursor.lockState = CursorLockMode.Locked;   
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); 
        
        if (z < 0)
        {
        rsens = -1f * val;
        } 
        else if (z > 0)
        {
        rsens = val;
        }
        
        if (z == 0)
        {
        rsens = 0f;
        }
        xRotation -= mouseY;
        hrot += mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        hrot = Mathf.Clamp(hrot, -30f, 30f);
        //transform.localRotation = Quaternion.Euler(xRotation, hrot, 0f);
        //move = move * x;
        playerBody.Rotate(Vector3.up * x * rsens);
        
        transform.localRotation = Quaternion.Euler(xRotation, hrot, 0);
        //cambd.Rotate(Vector3.up * mouseX * mouseSensitivity);
    }
}
