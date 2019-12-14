using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerNavigation : MonoBehaviour
{
    [SerializeField] float xSpeed = 40f;
    [SerializeField] float xDelta = 40f;
    [SerializeField] float ySpeed = 40f;
    [SerializeField] float yDelta = 40f;
    [SerializeField] float rxCorrection = 20f;
    [SerializeField] float ryCorrection = 20f;
    [SerializeField] float rxThrowCorrection = 20f;
    [SerializeField] float ryThrowCorrection = 20f;
    private bool failed;

    void InitiateFailure()
    {
        failed = true;
    }
    void Update()
    {
        if (failed)
        {
            return;
        }
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
        var kx = transform.localPosition.y / yDelta;
        var ky = transform.localPosition.x / xDelta;
        var xr = rxCorrection * kx - ryThrowCorrection * yMove * (1 - Mathf.Abs(kx));
        var yr = ryCorrection * ky + rxThrowCorrection * xMove * (1 - Mathf.Abs(ky));
        transform.localRotation = Quaternion.Euler(xr, yr, 0);
    }
}