using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public AudioSource audioClip;
    public void SoundSwitch()
    {
        audioClip.mute = !audioClip.mute;
    }
}
