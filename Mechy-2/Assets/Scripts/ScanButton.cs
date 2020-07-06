using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScanButton : MonoBehaviour
{
    public void SceneLoader(string SceneName)
    {
        SceneManager.LoadScene(SceneName);

    }
}
