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
    [SerializeField] float rxCorrection = 20f;
    [SerializeField] float ryCorrection = 20f;

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

        var xr = rxCorrection * transform.localPosition.y / yDelta;
        var yr = ryCorrection * transform.localPosition.x / xDelta;
        transform.localRotation = Quaternion.Euler(xr, yr, 0);
        print(ryCorrection * transform.localPosition.y / yDelta);
    }
}
