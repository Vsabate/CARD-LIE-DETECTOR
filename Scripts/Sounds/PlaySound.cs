using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource[] audioSources;

    /*
    [0] = Button sound
    [1] = Card shows sound
    */

    public void PlayButtonSound()
    {
        audioSources[0].PlayScheduled(0.1f);
    }

    public void PlayCardSound()
    {
        audioSources[1].Play();
    }

}
