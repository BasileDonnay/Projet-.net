using UnityEngine;
using System.Collections.Generic;

public class CameraFollow : MonoBehaviour
{
    public List<Transform> targets = new List<Transform>();

    public float smoothSpeed = 0.01f;
    public Vector3 offset = new Vector3(0, 0, -800);

    void FixedUpdate()
    {
        foreach (Transform target in targets)
        {
            if (target != null)
            {
                Vector3 desiredPosition = target.position + offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothedPosition;
            }
        }
    }
}
