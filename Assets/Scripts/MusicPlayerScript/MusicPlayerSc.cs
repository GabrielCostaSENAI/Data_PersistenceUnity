using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerSc : MonoBehaviour
{

    [SerializeField] private AudioSource audioSorce;
    [SerializeField] private Slider volumeSlider;
    

    private float musicVolume = 1f;

    void Start()
    {
        audioSorce.Play();
        musicVolume = PlayerPrefs.GetFloat("Volume");
        audioSorce.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    // Update is called once per frame
    void Update()
    { 
        audioSorce.volume = musicVolume;
        PlayerPrefs.SetFloat("Volume", musicVolume);
    }

    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }

}
