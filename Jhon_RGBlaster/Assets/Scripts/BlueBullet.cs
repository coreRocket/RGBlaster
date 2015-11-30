using UnityEngine;
using System.Collections;

public class BlueBullet : MonoBehaviour
{

    public float speed = 5;

    // Use this for initialization
    void Start()
    {
        var body = GetComponent<Rigidbody2D>();
        body.velocity = transform.up * speed;
    }


}
