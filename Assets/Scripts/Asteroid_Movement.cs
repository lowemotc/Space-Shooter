using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Movement : MonoBehaviour {
    public float speed = 1f;
    public Rigidbody2D rb;
    public Vector2 facing;

	// Use this for initialization
	void Start () {
        rb.AddForce(this.rb.position * speed, ForceMode2D.Impulse);
    }
}
