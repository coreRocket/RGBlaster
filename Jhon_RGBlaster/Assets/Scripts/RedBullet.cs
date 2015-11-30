using UnityEngine;
using System.Collections;

public class RedBullet : MonoBehaviour
{

    public float speed = 20;

	// Use this for initialization
	void Start ()
    {
        var body = GetComponent<Rigidbody2D>();
        body.velocity = transform.up * speed;

        Destroy(gameObject, 2f);
	}
}
