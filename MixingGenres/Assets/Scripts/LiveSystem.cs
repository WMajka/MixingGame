using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveSystem : MonoBehaviour
{
    [SerializeField] private int Lives = 3;
    [SerializeField] GameObject GetPlayer;

    private void Awake()
    {
        GetPlayer = GameObject.Find("Player");
    }

    public void RemoveLive()
    {
        Lives--;
        GetPlayer.SetActive(false);
    }
    private void Update()
    {
        Debug.Log("Lives " + Lives);
    }
    public void RestartPlayer()
    {
        if (Lives > 0)
        {
            GetPlayer.SetActive(true);
            GetPlayer.transform.position = new Vector2(0.0f, 0.0f);
        }
        else
        {
            Debug.Log("Game over");
        }
    }
}
