using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text textUI;
    public string levelText;
    void Awake()
    {
        // Subscribe to the OnLevelChanged event
        LevelSwitcher.OnLevelChanged += UpdateLevelUI;
        
    }

    void OnDestroy()
    {
        // Unsubscribe to prevent memory leaks
        LevelSwitcher.OnLevelChanged -= UpdateLevelUI;
    }

    private void UpdateLevelUI(string levelName)
    {
        textUI.text = "Current Level: " + levelName;
        

    }
}