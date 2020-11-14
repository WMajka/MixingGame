using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match3 : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToDestory = new List<GameObject>();
    [SerializeField] private ScoreSystem GetScoreSystem;


    public void AddToList(GameObject gameObjectToAdd)
    {
        if (!objectsToDestory.Contains(gameObjectToAdd))
        {
            if (objectsToDestory.Count > 0 && !gameObjectToAdd.CompareTag(objectsToDestory[0].gameObject.tag))
            {
                CompareObjecInList(gameObjectToAdd, objectsToDestory);
            }
            else
            {
                objectsToDestory.Add(gameObjectToAdd);
            }
        }
        if (objectsToDestory.Count == 3)
        {
            DeactivateAllObjects(objectsToDestory);
            ClearList(objectsToDestory);
            GetScoreSystem.AddMultiplier(gameObjectToAdd.tag);
            GetScoreSystem.AddScore();
        }
    }

    private void CompareObjecInList(GameObject gameObjectToAdd, List<GameObject> gameObjectList)
    {
        foreach (var item in gameObjectList)
        {
            var ColorToChange = item.gameObject.GetComponent<SpriteRenderer>();
            ColorToChange.color = Color.white;
        }
        gameObjectList.Clear();
        gameObjectList.Add(gameObjectToAdd);
    }
    private void ClearList(List<GameObject> gameObjectList)
    {
        gameObjectList.Clear();
    }
    private void DeactivateAllObjects(List<GameObject> gameObjectList)
    {
        foreach (var gameItem in gameObjectList)
        {
            gameItem.SetActive(false);
        }
    }

     
}
