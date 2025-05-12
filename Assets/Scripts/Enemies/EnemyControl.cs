using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : FSMSystem
{
    public float detect_range;
    public float attack_rank;
    public float attack_speed;
    public Transform trans;
    protected override void Awake()
    {
        base.Awake();
        trans = transform;
    }
    public virtual void Setup()
    {

    }
}
