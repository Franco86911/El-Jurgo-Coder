using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDespawn : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    private void OnTriggerEnter(Collider m_player)
    {
        enemy.SetActive(false);
        //DestroyThis;
    }
}
