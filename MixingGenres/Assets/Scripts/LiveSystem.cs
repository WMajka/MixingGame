using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LiveSystem : MonoBehaviour
{
    [SerializeField] private int Lives = 3;
    [SerializeField] GameObject GetPlayer;
    [SerializeField] private AudioSource GetAudio;

    private void Awake()
    {
        GetPlayer = GameObject.Find("Player");
        GetAudio = gameObject.GetComponent<AudioSource>();
    }

    public void RemoveLive()
    {
        Lives--;
        GetPlayer.SetActive(false);
        GetAudio.Play();
    }

    public void RestartPlayer(InputAction.CallbackContext context)
    {
        if (Lives > 0 && !GetPlayer.activeSelf)
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
