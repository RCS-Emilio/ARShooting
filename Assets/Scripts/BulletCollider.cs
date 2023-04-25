using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{
    public GameObject smoke;
    public AudioSource dead;
    public AudioSource cristal;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "monster") {
            dead.Play();
            Points.globalScore += 10;
            Destroy(collision.gameObject);
            var smokeEffectMonster =  Instantiate(smoke, collision.transform.position, collision.transform.rotation);
            Destroy(smokeEffectMonster, 3f);
        }

        if (collision.gameObject.tag == "jewel") {
            cristal.Play();
            Points.globalScore -= 10;
            Destroy(collision.gameObject);
            var smokeEffectJewel = Instantiate(smoke, collision.transform.position, collision.transform.rotation);
            Destroy(smokeEffectJewel, 3f);
        }
    }
}
