using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelIndexSave : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("LevelIndex"))
        {
            int levelIndex = PlayerPrefs.GetInt("LevelIndex");
            if (levelIndex != SceneManager.GetActiveScene().buildIndex)
            {
                SceneManager.LoadScene(levelIndex);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex != 1)
            SceneManager.LoadScene(1);
    }
    public void LevelSave()
    {
        PlayerPrefs.SetInt("LevelIndex", SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Bir derdim var " + PlayerPrefs.GetInt("LevelIndex"));
    }
}
