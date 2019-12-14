using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject explosionParticles;

    private void OnTriggerEnter(Collider other)
    {
        explosionParticles.SetActive(true);
        SendMessage("InitiateFailure");
        Invoke("Restart", 1.5f);
    }

    private void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
