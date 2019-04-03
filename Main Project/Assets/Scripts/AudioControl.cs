using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioClip[] audioClips;
    public int clipIndex;
    private AudioSource audioSource;

    private void Start(){
        audioSource = GetComponent<AudioSource>();
        PlayAudioClip(clipIndex);
    }

    public void PlayAudioClip(int clipToPlay){
        audioSource.clip = audioClips[clipToPlay];
        audioSource.Play();
    }
}
