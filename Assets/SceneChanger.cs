using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void StartGame()
    {
        PlayerPrefs.SetInt("loaded", 0);
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void GameLoad()
    {
        PlayerPrefs.SetInt("loaded", 1);
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    private void Awake()
    {
        PlayerPrefs.SetInt("loaded", 0);
    }
}
