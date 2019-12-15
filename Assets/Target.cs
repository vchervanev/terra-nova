using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] GameObject ExplosionFX;
    private void OnParticleCollision(GameObject other)
    {
        Instantiate(ExplosionFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
