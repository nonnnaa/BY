using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Zombie_AttackState : FSMState
{
    [HideInInspector]
    public ZombieControl parent; 
    private float time_count;
    public override void EnterState()
    {
        Debug.LogError(" enter attack state");
    }
    public override void UpdateState()
    {
        Debug.LogError(" update  attack state");
        time_count += Time.deltaTime;
        if (time_count > 2)
        {
            parent.GotoState(parent.wanderState);
        }
    }

    public override void ExitState()
    {
        Debug.LogError(" exit  attack state");
    }

}
