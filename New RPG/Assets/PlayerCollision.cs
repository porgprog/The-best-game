using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    void OnCollisionEnter(UnityEngine.Collision collisioninfo)
    {
        if (collisioninfo.gameObject.tag == "Obstical")
        {
            Debug.Log("We hit an obstical");
        }
    }
}
