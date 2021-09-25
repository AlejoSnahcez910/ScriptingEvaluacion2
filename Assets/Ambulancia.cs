using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulancia : Car, IAlert
{
    public Ambulancia() : base()
    {
        aceleracion = 40f;
    }

    public override void OnEnable()
    {
        brSO.greenEvent += Acelerate;
    }

    public override void OnDisable()
    {
        brSO.greenEvent -= Acelerate;
    }

    public void Alert()
    {
        Debug.Log("Aiudaaaaa");
    }

    public override void PlaySound()
    {
        Debug.Log("Wiuuu Wiuuu");
    }
}
