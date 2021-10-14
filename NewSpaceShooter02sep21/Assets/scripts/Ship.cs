using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ship : MonoBehaviour
{
    [SerializeField] protected Motor myMotor;

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
