using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBasic : MonoBehaviour {
    public Rigidbody rb;
    public Camera playerCam;
    public float MovementImpulse = 70;
    public Vector3 test = new Vector3();
    //Using FixedUpdate to mess with physics
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
 
        //Move in each direction on key press
        if (x > 0.5)
        {
            Vector3 rightV = MovementImpulse * playerCam.transform.TransformDirection(Vector3.right);
            rb.AddForce(Time.fixedDeltaTime * rightV, ForceMode.VelocityChange); // Only if condition is met
        }
        if (x < -0.5)
        {
            Vector3 leftV = MovementImpulse * playerCam.transform.TransformDirection(-Vector3.right);
            rb.AddForce(Time.fixedDeltaTime * leftV, ForceMode.VelocityChange);
        }
        if (z > 0.5)
        {
            Vector3 forwardV = MovementImpulse * playerCam.transform.TransformDirection(Vector3.forward);
            rb.AddForce(Time.fixedDeltaTime * new Vector3(forwardV.x, 0, forwardV.z) , ForceMode.VelocityChange);
        }
        if (z < -0.5)
        {
            Vector3 backwardV = MovementImpulse * playerCam.transform.TransformDirection(-Vector3.forward);
            rb.AddForce(Time.fixedDeltaTime * new Vector3(backwardV.x, 0, backwardV.z) , ForceMode.VelocityChange);
            test = backwardV;
        }
        //rb.AddForce(MovementImpulse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //rb.AddForce(0, 0, MovementImpulse * Time.deltaTime, ForceMode.VelocityChange);
    }
}