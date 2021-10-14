using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : Motor
{

<<<<<<< HEAD
<<<<<<< HEAD
    // Update is called once per frame
    void Update()
=======

    public delegate void Slowed(bool data);
    public static event Slowed _playerSlowed;

    protected override void Start()
>>>>>>> parent of e3adaa0 (Fail)
    {
        base.Start();
        maxManeuveringSpeed = 4;
    }
=======

    public delegate void Slowed(bool data);
    public static event Slowed _playerSlowed;

    
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of 9691f7b (ForwardSpeedStuff00)
=======
>>>>>>> parent of 9691f7b (ForwardSpeedStuff00)
=======
>>>>>>> parent of 9691f7b (ForwardSpeedStuff00)
=======
>>>>>>> parent of 9691f7b (ForwardSpeedStuff00)
=======
>>>>>>> parent of 9691f7b (ForwardSpeedStuff00)
}
