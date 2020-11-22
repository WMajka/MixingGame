using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Level SO", menuName ="Level")]
public class LevelController : ScriptableObject
{
    [SerializeField] public int LevelNumber;
    [SerializeField] public int NumberOfBigEnemy;
    [SerializeField] public int NumberOfMediumEnemy;
    [SerializeField] public int NumberOfSmallEnmey;

}
