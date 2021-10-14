using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Controller))]
public class Motor : MonoBehaviour
{
    protected Rigidbody body;
    [SerializeField] protected Controller control;

    [SerializeField] protected float maxSpeed;
    [SerializeField] protected float curSpeed;

    protected Vector3 pilotInput;

    protected virtual void Start()
    {
        body = GetComponent<Rigidbody>();
        control = GetComponent<Controller>();

        curSpeed = maxSpeed;
    }

    protected virtual void Update()
    {
        GetPilotInput();
    }

    protected virtual void FixedUpdate()
    {
        body.MovePosition(body.position + pilotInput);
        control.LockToScreen();
    }

    protected void GetPilotInput()
    {
        pilotInput = control.movement * curSpeed * Time.deltaTime;
        
    }

    public void SetSpeed(bool slow)
    {
        if (slow) curSpeed -= maxSpeed / 2;
    }
}
