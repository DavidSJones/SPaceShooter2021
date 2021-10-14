using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    public float xMove { get; protected set; }
    public float yMove { get; protected set; }
    public float zMove { get; protected set; }


    public Vector3 movement { get; protected set; }

    protected virtual void Update()
    {
        movement = new Vector3(xMove, yMove, zMove);
    }

    public void LockToScreen()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        float xLock = GameManager.instance.screeenSize.x - 1;

        if (transform.position.x < -xLock) { transform.position = new Vector3(-xLock, y, z); }
        else if (transform.position.x > xLock) { transform.position = new Vector3(xLock, y, z); }
    }
}
