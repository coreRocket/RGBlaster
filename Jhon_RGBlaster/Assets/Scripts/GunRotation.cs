using UnityEngine;
using System.Collections;

public class GunRotation : MonoBehaviour
{
	
	// Update is called once per frame
	void Update ()
    {
        RotateToMouse();
	}

    private void RotateToMouse()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RotateToTarget(mousePos);
    }

    void RotateToTarget(Vector3 targetPos)
    {
        //get length of x and y
        var deltaY = targetPos.y - transform.position.y;
        var deltaX = targetPos.x - transform.position.x;
        //get the arc-tan of x and y
        //then convert angle from radians to degree
        var targetAngle = Mathf.Atan2(deltaY, deltaX) * Mathf.Rad2Deg; 
        //clamp the angle so it wont rotate 360
        targetAngle = Mathf.Clamp(targetAngle, -45f, 90f);
        //apply angle as rotation
        transform.eulerAngles = Vector3.forward * targetAngle;
    }
}
