using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    void Start()
    {
        Invoke("StartGame", 2f);
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
