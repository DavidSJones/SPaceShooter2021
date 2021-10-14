using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : Motor
{


    public delegate void Slowed(bool data);
    public static event Slowed _playerSlowed;

    
}
