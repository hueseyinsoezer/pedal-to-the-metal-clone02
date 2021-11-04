using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherCarsController : MonoBehaviour
{
    private float speed;
    public otherCarSettings otherCarSettingsScript;
    

    void Start()
    {
        speed = otherCarSettingsScript.forwardSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        speed = otherCarSettingsScript.forwardSpeed;

        transform.Translate(Vector3.forward*speed*Time.deltaTime);

    }
}
