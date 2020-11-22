using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuControl : MonoBehaviour
{
    [SerializeField] private GameObject GetPauseMenu;
    [SerializeField] private PauseMenu GetPause;
    private void Start()
    {
        GetPauseMenu.SetActive(false);
    }

    private void LateUpdate()
    {
        GetPauseMenu.SetActive(GetPause.isGamePaused);
    }
}
