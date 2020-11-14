using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] SpawnPoints;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private LevelController GetLevelController;

    private void Start()
    {
        for (int i = 0; i < GetLevelController.NumberOfSpawner; i++)
        {
            Instantiate(Enemy, SpawnPoints[Random.Range(0, 9)]);
        }
    }
}
