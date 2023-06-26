using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : Entity
{
    [SerializeField] private Animator m_animator;
    [SerializeField] private EnemyScriptableObject m_data;
    

    public void MoveCharacter(Vector3 p_direction)
    {
        transform.position += p_direction * m_data.speed * Time.deltaTime; 
    }
}
