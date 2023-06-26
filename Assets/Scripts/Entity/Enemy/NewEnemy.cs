using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewEnemy : EnemyCharacter
{
    private Transform p_target;

    public void PursuitPlayer()
    {
        var l_dir = (p_target.position - transform.position).normalized;
        MoveCharacter(l_dir);
    }
}
