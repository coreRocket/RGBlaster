using UnityEngine;
using System.Collections;

public class WallSplat : MonoBehaviour
{
    public GameObject Splat;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "splat")
        {
            var pos = collision.transform.position;
            pos.y = transform.position.y - .5f;
            var splat = Instantiate(Splat, pos, Quaternion.identity);
            Destroy(splat, 5f);
        }
            Destroy(collision.gameObject);
    }
}
