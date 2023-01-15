using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveShootable : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag == "monster") {
            Points.globalScore -= 20;
            Destroy(collision.gameObject);
        }

        if (collision.transform.tag == "jewel") {
            Destroy(collision.gameObject);
        }
    }
}
