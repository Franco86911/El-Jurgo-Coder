using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/EnemyScriptableObject")]

public class EnemyScriptableObject : ScriptableObject
{
    public float speed;
    public float r_speed;
    public RaycastChase p_detected;
    public float e_nearLimit = 2;
    public float e_distanceToChase;
}
