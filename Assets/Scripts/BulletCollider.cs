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
        if (collision.transform.tag == "monster") {
            dead.Play();
            Points.globalScore += 10;
            Destroy(collision.transform.gameObject);
            var smokeEffectMonster =  Instantiate(smoke, collision.transform.position, collision.transform.rotation);
            Destroy(smokeEffectMonster, 3f);
        }

        if (collision.transform.tag == "jewel") {
            cristal.Play();
            Points.globalScore -= 10;
            Destroy(collision.transform.gameObject);
            var smokeEffectJewel = Instantiate(smoke, collision.transform.position, collision.transform.rotation);
            Destroy(smokeEffectJewel, 3f);
        }
    }
}
