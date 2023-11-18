using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    public AudioClip music;
    public AudioSource theme;
    public enum eAudio { 
        PLAY,
        LOOP,
        END
    }
    public eAudio audioSettings;
    // Start is called before the first frame update
    void Start() {
        switch (audioSettings) {
            case eAudio.PLAY:
                theme.Play();
                break;
            case eAudio.LOOP:
                theme.Play();
                theme.loop = true;
                break;
            case eAudio.END:
                theme.Stop();
                break;
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}