using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    //PlayerPrefs.GetInt("Sound", 1); // ilk açılışta açık.

    // PlayerPrefs.SetInt("Sound", 0); // kapalı
    // PlayerPrefs.SetInt("Sound", 1); // açık
    public AudioSource audioSource;
    public Toggle toggle;

    void Start()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            audioSource.Play();
            toggle.isOn = true;
        }
    }

    public void SwitchSound()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
            PlayerPrefs.SetInt("Sound", 0);
        }
        else
        {
            audioSource.Play();
            PlayerPrefs.SetInt("Sound", 1);
        }
    }
}