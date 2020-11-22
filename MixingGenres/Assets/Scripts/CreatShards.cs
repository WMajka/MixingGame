using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatShards : MonoBehaviour
{
    [SerializeField] private GameObject SmallerObject;
    [SerializeField] private SpawnEnemy GetSpawnEnemy;
    [SerializeField] private bool isItMediumEnemy;

    private void Awake()
    {
        GetSpawnEnemy = GameObject.Find("GameManager").GetComponent<SpawnEnemy>();
    }

    private void OnDisable()
    {
        if (isItMediumEnemy)
        {
            for (int i = 0; i < GetSpawnEnemy.MediumEnemy; i++)
            {
                Instantiate(SmallerObject, gameObject.transform.position, gameObject.transform.rotation);
            }
        }
        else
        {
            for (int i = 0; i < GetSpawnEnemy.SmallEnemy; i++)
            {
                Instantiate(SmallerObject, gameObject.transform.position, gameObject.transform.rotation);
            }
        }
    }
}
