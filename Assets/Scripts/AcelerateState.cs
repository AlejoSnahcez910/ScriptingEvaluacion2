using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcelerateState : MonoBehaviour, ICarState
{
    public void Execute(Car car)
    {
        car.Speed = 10f;
    }
}