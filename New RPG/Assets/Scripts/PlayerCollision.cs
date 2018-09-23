using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMomvment Momvment;

    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obsticle")
        {
            Momvment.enabled = false;
        }
    }
}
