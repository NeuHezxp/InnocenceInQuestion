using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public AudioManager audio;
    public void Play() {
        audio.stopMusic();
        audio.soundName = "Investigation";
        audio.PlayMusic(audio.soundName);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit() {
        Application.Quit();
        Debug.Log("player quit");
    }
}
