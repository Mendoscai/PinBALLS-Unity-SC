using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject sfxBumperAudioSource;
    public GameObject sfxSwitch;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBGM()
    {
        audioSource.Play();
    }

    public void PlayBumperSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxBumperAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitch, spawnPosition, Quaternion.identity);
    }
}
