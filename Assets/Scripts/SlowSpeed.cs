using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowSpeedState : ICarState
{
    public void Execute(Car car)
    {
        car.Speed = 5f;
    }

    public void Execute(Ambulancia Amb)
    {
        Amb.Speed = 5f;
    }
}
