using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Generator))]
[RequireComponent(typeof(PowerSupply))]
public class PlayerShip : Ship
{
    //PowerSupply
    protected Generator myGene;
    protected PowerSupply myPS;

    protected override void Start()
    {
        base.Start();

        myGene = GetComponent<Generator>();
        myPS = GetComponent<PowerSupply>();
    }

    protected override void Update()
    {
        base.Update();

        UseGenerator();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();


    }
    private void UseGenerator()
    {
        //adds power from generator to power supply when current power is under base power
        if (myPS.curPower >= myPS.maxPower) return;
        else if (myPS.curPower + myGene.GetPower() > myPS.maxPower) myPS.ResetPower();
        else myPS.AddPower(myGene.GetPower());
    }
}
