using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] SpawnPoints;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private LevelController GetLevelController;
    public int MediumEnemy { get; private set; }
    public int SmallEnemy { get; private set; }

    private void Awake()
    {
        MediumEnemy = GetLevelController.NumberOfMediumEnemy;
        SmallEnemy = GetLevelController.NumberOfSmallEnmey;
    }
    private void Start()
    {
        StartCoroutine(SpawnMyEnemy());
    }
    IEnumerator SpawnMyEnemy()
    {
        for (int i = 0; i < GetLevelController.NumberOfBigEnemy; i++)
        {
            Instantiate(Enemy, SpawnPoints[Random.Range(0, 11)]);
        }
        yield return new WaitForSeconds(60);

        StartCoroutine(SpawnMyEnemy());
    }
}
