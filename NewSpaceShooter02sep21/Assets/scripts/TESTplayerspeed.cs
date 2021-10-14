using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTplayerspeed : MonoBehaviour
{
    private Rigidbody body;

    public float playerSpeed;
    public float myspeed;
    private float speed;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        speed = playerSpeed + myspeed;
    }

    private void FixedUpdate()
    {
        body.MovePosition(transform.position + new Vector3(0, -speed, 0) * Time.deltaTime);
    }
}
