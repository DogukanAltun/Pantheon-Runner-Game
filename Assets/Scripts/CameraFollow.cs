using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 10.0f;
    public Vector3 dist;
    public Transform lookTarget;
    void Start()
    {

    }
    void LateUpdate()
    {
        Vector3 dPos = target.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, speed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }
}
