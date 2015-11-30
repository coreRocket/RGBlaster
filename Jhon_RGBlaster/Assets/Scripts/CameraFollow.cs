using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;

    public float offset;
	// Use this for initialization
	void Start ()
    {
        offset = transform.position.x - playerTransform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void LateUpdate()
    {
        var desiredPos = playerTransform.position;
        desiredPos.y = transform.position.y;
        desiredPos.z = -10;
        desiredPos.x += offset;
        transform.position = desiredPos;
    }
}
