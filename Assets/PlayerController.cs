using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject explosionParticles;
    bool failed;

    private void OnTriggerEnter(Collider other)
    {
        if(failed)
        {
            return;
        }
        failed = true;
        explosionParticles.SetActive(true);
        SendMessage("InitiateFailure");
        Invoke("Restart", 1.5f);
    }

    private void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
