using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager Instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;
    public string soundName = "";

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    private void Start() {
        PlayMusic(soundName); //add main menu music.
    }

    public void PlayMusic(string name) {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null) {
            Debug.Log("sound null");
        } else {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name) {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null) {
            Debug.Log("sound null");
        } else {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void stopMusic() { 
        musicSource.Stop();
    }

    public void stopSFX() {
        sfxSource.Stop();
    }

    public void stopAll() {
        stopMusic();
        stopSFX();
    }
}
