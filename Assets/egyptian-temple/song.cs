using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicPlayer : MonoBehaviour
{
    // Reference to the Audio Source component
    private AudioSource audioSource;

    // The music clip to play
    public AudioClip musicClip;

    // Whether the music should loop
    public bool loop = true;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Audio Source component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Set the music clip to play
        audioSource.clip = musicClip;

        // Set whether the music should loop
        audioSource.loop = loop;

        // Play the music
        audioSource.Play();
    }
}
