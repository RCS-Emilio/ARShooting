using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public AudioSource bgSound;
    // Start is called before the first frame update
    void Start() {
        var sound = GameObject.Find("bgSound(Clone)");
        if(sound == null )
            DontDestroyOnLoad(Instantiate(bgSound));
    }

    public void GoToScene(string scene) {
        SceneManager.LoadScene(scene);
    }
}
