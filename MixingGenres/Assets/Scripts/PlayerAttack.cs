using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject GetBullet;
    [SerializeField] Transform GetTransformForFire;
    public void PlayerAction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Instantiate(GetBullet, GetTransformForFire.transform.position, GetTransformForFire.transform.rotation);
        }
    }
    
}
