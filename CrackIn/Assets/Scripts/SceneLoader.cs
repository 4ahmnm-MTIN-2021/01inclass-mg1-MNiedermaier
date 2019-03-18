using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    enum Scenes { StartScene, MainScene, GameOverScene };

    public void LoadStartScene()
    {
        SceneManager.LoadScene((int)Scenes.StartScene);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene((int)Scenes.MainScene);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene((int)Scenes.GameOverScene);
    }

}