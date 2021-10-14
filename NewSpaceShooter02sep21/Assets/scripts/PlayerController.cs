using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    protected override void Update()
    {
        SetXmove();
        SetYmove();
        setZmove();

        base.Update();

        Debug.Log(movement);
    }

    protected void SetXmove() { xMove = Input.GetAxis("Horizontal"); }
    protected void SetYmove() { yMove = 0; }
    protected void setZmove() { zMove = 0; }
}
