using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Zombie_WanderState : FSMState
{
    [HideInInspector]
    public ZombieControl parent;
  
    private Vector3 ogrinal_pos;
    private Vector3 pos_move;
    public override void EnterState()
    {
        Debug.LogError(" enter wander state");
        ogrinal_pos = parent.trans.position;
        float x = UnityEngine.Random.Range(-5f, 5f);
        float z = UnityEngine.Random.Range(-5f, 5f);
        pos_move = ogrinal_pos + new Vector3(x, 0, z);
    }
    public override void UpdateState()
    {
        Vector3 dir = pos_move - parent.trans.position;
        dir.Normalize();
        parent.trans.forward = dir;
        //lerp
       // parent.trans.position = Vector3.Lerp(parent.trans.position, pos_move, Time.deltaTime * 1);
        // move to
        parent.trans.position = Vector3.MoveTowards(parent.trans.position, pos_move, Time.deltaTime * 3);
        if (Vector3.Distance(parent.trans.position,pos_move)<=0.1f)
        {
            float x = UnityEngine.Random.Range(-5f, 5f);
            float z = UnityEngine.Random.Range(-5f, 5f);
            pos_move = ogrinal_pos + new Vector3(x, 0, z);
        }
    }

    public override void ExitState()
    {
        Debug.LogError(" exit  wander state");
    }
}
