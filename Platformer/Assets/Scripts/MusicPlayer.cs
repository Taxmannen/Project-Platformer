using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    public AudioClip stageMusic;
    [Range(0.2f, 0.5f)]
    public float stageMusicVolume;
    public AudioClip bossMusic;
    [Range(0.1f, 1f)]
    public float bossMusicVolume;

    AudioSource audioSource;
    bool isBoss = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && other.isTrigger)
        {
            isBoss = !isBoss;
            if (isBoss)
            {
                audioSource.volume = bossMusicVolume;
                audioSource.clip = bossMusic;
            }
            else
            {
                audioSource.volume = stageMusicVolume;
                audioSource.clip = stageMusic;
            }
            audioSource.Play();
        }
    }
}
