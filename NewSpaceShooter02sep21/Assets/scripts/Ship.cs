using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
[RequireComponent(typeof(Motor))]
public abstract class Ship : MonoBehaviour
{
    protected Motor myMotor;
=======
public abstract class Ship : MonoBehaviour
{
    [SerializeField] protected Motor myMotor;
>>>>>>> parent of e3adaa0 (Fail)

    protected virtual void Start()
    {
        myMotor = GetComponent<Motor>();
    }

    protected virtual void Update()
    {
        
    }

    protected virtual void FixedUpdate()
    {

    }

    protected virtual void ReduceSpeed()
    {

    }
}
