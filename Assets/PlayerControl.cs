using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float moveForce = 1f;          // Amount of force added to move the player left and right.

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Cache the horizontal input.
        float h = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * h * moveForce);
    }
}
