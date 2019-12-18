using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public GameObject btnOn;
    public GameObject btnOff;
    public Slider slider;
    public Text valueCount;
    AudioSource audioSource;
    void Update()
    {
        valueCount.text = slider.value.ToString();
    }
    void Start()
    {



        audioSource = Camera.main.GetComponent<AudioSource>();
        DontDestroyOnLoad(transform.gameObject);

    }
    public void PlayAudio()
    {
        audioSource.Play();

    }
    public void StopAudio()
    {
        audioSource.Stop();
    }

    public void f()
    {
        audioSource.volume = slider.value;
    }
}
