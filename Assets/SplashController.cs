using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    void Start()
    {
        Invoke("StartGame", 2f);
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
