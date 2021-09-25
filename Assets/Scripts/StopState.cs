using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StopState : ICarState
{
    public void Execute(Car car)
    {
        car.Speed = 0f;
    }

    public void Execute (Ambulancia Amb)
    {
        Amb.Speed = 0;
    }
}
