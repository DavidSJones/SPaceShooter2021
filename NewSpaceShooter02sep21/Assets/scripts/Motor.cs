using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Controller))]
public class Motor : MonoBehaviour
{
    protected Rigidbody body;
    [SerializeField] protected Controller control;

    protected PowerSupply myPower;










    protected float maxForwardSpeed;
    protected float curForwardSpeed;

    [SerializeField] protected float maxManeuveringSpeed;
    [SerializeField] protected float curManeuveringSpeed;

    protected Vector3 pilotInput;

    protected virtual void Start()
    {
        body = GetComponent<Rigidbody>();
        control = GetComponent<Controller>();

        curForwardSpeed = maxForwardSpeed;
        curManeuveringSpeed = maxManeuveringSpeed;
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
        Vector3 _inputs = new Vector3(0,0,0);

        _inputs.x = control.movement.x * curManeuveringSpeed;
        _inputs.y = control.movement.y * curForwardSpeed;
        _inputs.z = control.movement.z * curManeuveringSpeed;

        pilotInput = _inputs * Time.deltaTime;
    }

    public void SetSpeed(bool slow)
    {

    }
}
