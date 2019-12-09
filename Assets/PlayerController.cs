using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float xSpeed = 40f;
    [SerializeField] float xDelta = 40f;
    [SerializeField] float ySpeed = 40f;
    [SerializeField] float yDelta = 40f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = CrossPlatformInputManager.GetAxis("Horizontal");
        float dx = xMove * xSpeed * Time.deltaTime;
        float yMove = CrossPlatformInputManager.GetAxis("Vertical");
        float dy = yMove * ySpeed * Time.deltaTime;
        Vector3 newPosition = transform.localPosition + new Vector3(dx, dy, 0);
        transform.localPosition = new Vector3(
            Mathf.Clamp(newPosition.x, -xDelta, xDelta),
            Mathf.Clamp(newPosition.y, -yDelta, yDelta),
            newPosition.z
        );
    }
}
