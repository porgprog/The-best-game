using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
	}

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
