using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerSupply : MonoBehaviour
{
    public float maxPower { get; protected set; }
    public float curPower { get; protected set; }
    public float maxDraw { get; protected set; }

    protected virtual void Start()
    {

    }

    public bool DrawPower(float _powerRequested)
    {
        bool allow;
        float powerDrawn;

        if (curPower < maxDraw)
        {
            if (_powerRequested > curPower)
            {
                allow = false;
                powerDrawn = curPower;
            }
            else
            {
                allow = true;
                powerDrawn = _powerRequested;
            }
        }
        else
        {
            if (_powerRequested > maxDraw)
            {
                allow = false;
                powerDrawn = maxDraw;
            }
            else
            {
                allow = true;
                powerDrawn = _powerRequested;
            }
        }

        curPower -= powerDrawn;
        return allow;
    }

    public void AddPower(float _power)
    {
        curPower += _power;
    }
}
