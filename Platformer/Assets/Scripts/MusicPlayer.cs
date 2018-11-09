using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    public AudioClip bossMusic;
    [Range(0.1f, 1f)]
    public float bossMusicVolume;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && other.isTrigger)
        {
            audioSource.volume = bossMusicVolume;
            audioSource.clip = bossMusic;
            audioSource.Play();
        }
    }
}
