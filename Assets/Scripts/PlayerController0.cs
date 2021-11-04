using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController0 : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 55.0f;
    public float horizontalInput2, verticalInput2, horizontalInput1, verticalInput1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput2 = Input.GetAxis("Horizontal2");
        horizontalInput1 = Input.GetAxis("Horizontal1");
        verticalInput2 = Input.GetAxis("Vertical2");
        verticalInput1 = Input.GetAxis("Vertical1");
        
        
        //Move the vehicle forward
        //removed because of usage, but is similar: transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput2);//With deltaTime we can control how much time is actually passing, this makes forward(0,0,20) for a second
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput1);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed* horizontalInput);   //Vector3.right equals (1,0,0), this formel means that our vehicle moves (turnSpeed,0,0) per second (There is no rotation)  
        transform.Rotate(Vector3.up, horizontalInput2*Time.deltaTime*turnSpeed);// right/left movement with rotation
        transform.Rotate(Vector3.up, horizontalInput1 * Time.deltaTime * turnSpeed);

    }
}
