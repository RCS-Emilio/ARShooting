using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColide : MonoBehaviour
{
    public GameObject smoke;
    public AudioSource dead;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag == "monster") {
            dead.Play();
            Points.globalScore += 10;
            Destroy(collision.transform.gameObject);
            Instantiate(smoke, collision.transform.position, collision.transform.rotation);
        }
    }
}
