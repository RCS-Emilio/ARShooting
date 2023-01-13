using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] monster;
    public Transform arCam;
    // Start is called before the first frame update
    void Start()
    {
        arCam = Camera.main.transform;
        StartCoroutine("StartSpawn");
    }

    IEnumerator StartSpawn() {
        yield return new WaitForSeconds(4f);
        for (int i = 0; i < 3; i++) {
            //new Vector3(Random.Range(-5f, 5f), Random.Range(1f, 3f), arCam.forward * Random.Range(6f, 10f)
            var instancia = Instantiate(monster[i], arCam.position + arCam.forward * 5f, Quaternion.identity);
            instancia.transform.position = instancia.transform.position + new Vector3(Random.Range(-5f, 5f), Random.Range(1f, 3f), Random.Range(-2f, 3f))   ;
            instancia.transform.LookAt(arCam.position);
        }
        StartCoroutine(StartSpawn());
    }

}
