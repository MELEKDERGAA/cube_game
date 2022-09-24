using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicscript : MonoBehaviour
{
    public static musicscript instance;

    public void Awake()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        Scene scene=SceneManager.GetActiveScene();
        if (scene.name == "start")
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }


        
    }
}
