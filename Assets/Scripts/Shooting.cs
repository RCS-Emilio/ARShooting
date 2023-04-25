using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Shooting : MonoBehaviour
{
    public AudioSource sound;
    private Camera arCamera;
    public GameObject bullet;
    public float shootForce = 700f;
    private bool cooldown = false;
    // Start is called before the first frame update
    void Start()
    {

        arCamera = Camera.main;
}

    public void Shoot() {
        if (cooldown == false) {
            GameObject bulletObject = Instantiate(bullet, arCamera.transform.position + arCamera.transform.forward, arCamera.transform.rotation) as GameObject;
            sound.Play();
            bulletObject.GetComponent<Rigidbody>().AddForce(arCamera.transform.forward * shootForce);
            Invoke("ResetCooldown", 0.6f);
            cooldown = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResetCooldown() {
        cooldown = false;
    }
}
