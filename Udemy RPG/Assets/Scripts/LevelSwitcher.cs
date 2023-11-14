using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    public int LevelIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(LevelIndex++); // Load the next level
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(LevelIndex--); // Load the next level
        }
    }
}
