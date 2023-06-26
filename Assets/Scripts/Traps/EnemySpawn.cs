using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Chase[] e_monsterSpawn;
    [SerializeField] private Transform spawnPoint;
    
    private void Awake()
    {
        enemy.SetActive(false);
    }

    private void OnTriggerEnter(Collider m_player)
    {
        enemy.SetActive(true);
        //Instantiate(e_monsterSpawn[0], spawnPoint);
    }
}
