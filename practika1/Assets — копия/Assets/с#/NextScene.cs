using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private string sceneName;
    public float TimerNextScene;
    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        Invoke("DoSomething", TimerNextScene);
    }
    void DoSomething()
    {
        SceneManager.LoadScene(sceneName);
    }

}
