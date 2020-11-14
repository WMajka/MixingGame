using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Level SO", menuName ="Level")]
public class LevelController : ScriptableObject
{
    [SerializeField] public int NumberOfLevel;
    [SerializeField] public int NumberOfSpawner;

}
