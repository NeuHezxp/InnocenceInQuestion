using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    public int LevelIndex;

    // Define a delegate and an event to notify about level changes
    public delegate void LevelChangeAction(string levelName);
    public static event LevelChangeAction OnLevelChanged;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            LoadNextLevel();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LoadPreviousLevel();
        }
    }
    void LoadNextLevel()
    {
        LevelIndex++;
        LoadLevel(LevelIndex);
    }

    void LoadPreviousLevel()
    {
        LevelIndex--;
        LoadLevel(LevelIndex);
    }

    void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
        // Notify subscribers (e.g., LogicScript) about the level change
        OnLevelChanged?.Invoke(SceneManager.GetSceneByBuildIndex(index).name);
    }
   
}
