using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Car : MonoBehaviour, ISound
{
    [SerializeField] protected ButtonReader brSO = default;
    [SerializeField] private float speed;
    [SerializeField] protected float aceleracion = 10f;
    private ICarState icarState;
    protected IMovement imovement;

    public float Speed { get => speed; set => speed = value; }
    public float Aceleracion { get => aceleracion; set => aceleracion = value; }

    void Awake()
    {
        icarState = new AcelerateState();
        icarState.Execute(this);

        imovement = GetComponent<IMovement>();
    }

    public virtual void OnEnable()
    {
        brSO.greenEvent += Acelerate;
        brSO.redEvent += Stop;
        brSO.yellowEvent += SlowSpeed;
    }
    public virtual void OnDisable()
    {
        brSO.greenEvent -= Acelerate;
        brSO.redEvent -= Stop;
        brSO.yellowEvent -= SlowSpeed;
    }
     public void Update()
    {
        imovement.Move(Speed);
        PlaySound();
    }

    public void Acelerate()
    {
        icarState = new AcelerateState();
        icarState.Execute(this);
    }

    public void SlowSpeed()
    {
        icarState = new SlowSpeedState();
        icarState.Execute(this);
    }
    public void Stop()
    {
        icarState = new StopState();
        icarState.Execute(this);
    }

    public virtual void PlaySound()
    {
        Debug.Log("Pi Pi");
    }
}
