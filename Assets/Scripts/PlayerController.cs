using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 55.0f;
    private float horizontalInput, verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        //removed because of usage, but is similar: transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);//With deltaTime we can control how much time is actually passing, this makes forward(0,0,20) for a second
       //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed* horizontalInput);   //Vector3.right equals (1,0,0), this formel means that our vehicle moves (turnSpeed,0,0) per second (There is no rotation)  
        transform.Rotate(Vector3.up, horizontalInput*Time.deltaTime*turnSpeed);// right/left movement with rotation

    }
}
