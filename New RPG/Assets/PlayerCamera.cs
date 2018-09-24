using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
    public GameObject Player;
    public float TPVDist;
    public float Speed;
    public float deltatimeTest;
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance (Player.transform.position, transform.position);

        if(TPVDist < dist)
        {
            transform.LookAt(Player.transform);

            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position + Vector3.up * 1, Speed * Time.deltaTime);
            deltatimeTest = Time.deltaTime;
        }
        else
        {
            transform.LookAt(Player.transform);
        }
    }
}
