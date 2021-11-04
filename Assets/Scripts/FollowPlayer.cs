using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private bool pressedV;
    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 closeOffset = new Vector3(0, 2, 5/10);

    // Start is called before the first frame update
    void Start()
    {
        pressedV = false;
    }

    // Update is called once per frame
    void LateUpdate()//firstly moves the vehicle then the camera
    {
        //Offset the camera behind the player by adding to the player's position.
        if (Input.GetKeyDown("v"))
        {
            pressedV = true;
        }
        else if (Input.GetKeyDown("b"))
        {
            pressedV = false;
            Debug.Log("DüzgünGörüþte");
        }
        if (pressedV == false)
        {
            this.transform.position = player.transform.position + offset;
            Debug.Log("DüzgünGörüþte");
        }
        else if (pressedV == true)
        {
            this.transform.position = player.transform.position + closeOffset;
            this.transform.rotation = player.transform.rotation;
            Debug.Log("YakýnGörüþte");
        }
    }
}
