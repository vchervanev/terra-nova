using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject explosionParticles;

    private void OnTriggerEnter(Collider other)
    {
        explosionParticles.SetActive(true);
        SendMessage("InitiateFailure");
    }
}
