using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeMonster : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag == "planes") {
            Points.globalScore -= 20;
            Destroy(this.gameObject);
        }
    }
}
