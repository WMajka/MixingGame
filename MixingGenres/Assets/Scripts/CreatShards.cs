using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatShards : MonoBehaviour
{
    [SerializeField] private GameObject[] SmallerObjects = new GameObject[3];

    private void OnDisable()
    {
        foreach (var item in SmallerObjects)
        {
            Instantiate(item, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
