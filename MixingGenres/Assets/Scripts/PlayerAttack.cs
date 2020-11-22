using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject GetBullet;
    [SerializeField] Transform GetTransformForFire;
    [SerializeField] AudioSource GetAudio;
    public void PlayerAction(InputAction.CallbackContext context)
    {
        if (context.started && gameObject.activeSelf)
        {
            Instantiate(GetBullet, GetTransformForFire.transform.position, GetTransformForFire.transform.rotation);
            GetAudio.Play();
        }
    }
    
}
