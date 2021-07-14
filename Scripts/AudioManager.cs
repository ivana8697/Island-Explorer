using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //private static AudioPlayerManager instance = null;
    private AudioSource audio;

    private void Awake()
    {
        
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
