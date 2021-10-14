using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSupply : MonoBehaviour
{
    public float maxPower { get; private set; }
    public float curPower { get; private set; }

    protected void Start()
    {
        curPower = maxPower;
    }

    public void AddPower(float _power)
    {
        curPower += _power;
    }

    public void UsePower(float _power)
    {
        curPower -= _power;
    }

    public void ResetPower()
    {
        curPower = maxPower;
    }
}
