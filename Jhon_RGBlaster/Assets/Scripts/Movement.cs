using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    private Rigidbody2D body;
    public float MaxSpeed = 5f;

    private float move = 0f;
    // Use this for initialization
    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        move = Input.GetAxis("Horizontal");
	}

    void FixedUpdate()
    {
        body.velocity = new Vector2(move * MaxSpeed, body.velocity.y);
    }
}
