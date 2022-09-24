using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicstart : MonoBehaviour
{
    public AudioClip audio;
    private void play()
    {
        AudioSource audiosource=GetComponent<AudioSource>();
        audiosource.clip = audio;
    }
}
