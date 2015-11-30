using UnityEngine;
using System.Collections;

public class FireGun : MonoBehaviour
{
    public Transform GunHead;
    public GameObject redBullet;
    public GameObject greenBullet;
    public GameObject blueBullet;

    private GameObject selectedBullet;

    public float FireRate = 0.2f;
    private float nextFire = 0f;

    void Start()
    {
        selectedBullet = redBullet;
    }
		
	// Update is called once per frame
	void Update ()
    {
        CheckBulletChange();
        CheckFire();
	}

    void CheckFire()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + FireRate;
            var angles = GunHead.transform.rotation.eulerAngles;
            angles.z += 270f; //270 because of the bullets weird transform
            Instantiate(selectedBullet, GunHead.transform.position, Quaternion.Euler(angles));
        }
    }

    void CheckBulletChange()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedBullet = redBullet;
            FireRate = 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedBullet = greenBullet;
            FireRate = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedBullet = blueBullet;
            FireRate = .5f;
        }
    }
}
