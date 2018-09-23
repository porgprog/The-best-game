using UnityEngine;

public class PlayerMomvment : MonoBehaviour {

    public Rigidbody rb;

    public float ForwardForce = 2000;

	// Use this for initialization
	void Start ()
    {
        	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
    }
}
