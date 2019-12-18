using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mus : MonoBehaviour

{
    public static bool music;
    AudioSource audioSource;
    void Start()
    {
        if (music == false)
        {
            audioSource.Play();
            music = true;
        }
        else { audioSource.Stop(); }
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

   
}
