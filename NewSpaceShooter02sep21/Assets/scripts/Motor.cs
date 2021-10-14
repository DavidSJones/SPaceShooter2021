using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Controller))]
public class Motor : MonoBehaviour
{
    protected Rigidbody body;
    [SerializeField] protected Controller control;

<<<<<<< HEAD
    [SerializeField] protected float maxSpeed;
    [SerializeField] protected float curSpeed;
=======
    protected float maxForwardSpeed;
    protected float curForwardSpeed;

    [SerializeField] protected float maxManeuveringSpeed;
    [SerializeField] protected float curManeuveringSpeed;
>>>>>>> parent of e3adaa0 (Fail)

    protected Vector3 pilotInput;

    protected virtual void Start()
    {
        body = GetComponent<Rigidbody>();
        control = GetComponent<Controller>();

<<<<<<< HEAD
        curSpeed = maxSpeed;
=======
        curForwardSpeed = maxForwardSpeed;
        curManeuveringSpeed = maxManeuveringSpeed;
>>>>>>> parent of e3adaa0 (Fail)
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
<<<<<<< HEAD
        pilotInput = control.movement * curSpeed * Time.deltaTime;
        
=======
        Vector3 _inputs = new Vector3(0,0,0);

        _inputs.x = control.movement.x * curManeuveringSpeed;
        _inputs.y = control.movement.y * curForwardSpeed;
        _inputs.z = control.movement.z * curManeuveringSpeed;

        pilotInput = _inputs * Time.deltaTime;
>>>>>>> parent of e3adaa0 (Fail)
    }

    public void SetSpeed(bool slow)
    {
<<<<<<< HEAD
        if (slow) curSpeed -= maxSpeed / 2;
=======
        if (slow) curManeuveringSpeed -= maxManeuveringSpeed / 2;
>>>>>>> parent of e3adaa0 (Fail)
    }
}
