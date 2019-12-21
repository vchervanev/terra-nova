using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] GameObject ExplosionFX;
    ScoreBoard scoreBoard;

    private void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();   
    }

    private void OnParticleCollision(GameObject other)
    {
        Instantiate(ExplosionFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
        scoreBoard.OnHit();
    }
}
