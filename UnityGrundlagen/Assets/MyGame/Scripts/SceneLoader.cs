using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}