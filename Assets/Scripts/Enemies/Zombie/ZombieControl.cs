using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : EnemyControl
{
    public Zombie_AttackState attackState;
    public Zombie_ChaseState chaseState ;
    public Zombie_DeadState deadState;
    public Zombie_WanderState wanderState;

   
    protected override void Start()
    {
        base.Start();
        attackState.parent = this;
        chaseState.parent = this;
        deadState.parent = this;
        wanderState.parent = this;
        GotoState(wanderState);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detect_range);
    }

}
