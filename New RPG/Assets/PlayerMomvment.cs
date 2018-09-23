using UnityEngine;

public class PlayerMomvment : MonoBehaviour {

    public Rigidbody rb;

    public float ForwardForce = 2000;
    public float SideForce = 1000;
    

	// Use this for initialization
	void Start ()
    {
        	
	}
	
	//Using FixedUpdate to mess with physics
	void FixedUpdate ()
    {
            // Add a Forward Force
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if( Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0); // Only if condition is met
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0);
        }
    }
}
