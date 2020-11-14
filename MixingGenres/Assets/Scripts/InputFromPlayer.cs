using UnityEngine;
using UnityEngine.InputSystem;

public class InputFromPlayer : MonoBehaviour
{
    public float GetForce { get; private set; }
    public float GetRotation { get; private set; }
    public bool GetAction { get; set; }

    public void PlayerActionVector(InputAction.CallbackContext context)
    {
        Vector2 GetPlayerVector2 = context.ReadValue<Vector2>();
        
        GetRotation = GetPlayerVector2.x;
        GetForce = GetPlayerVector2.y;
    }



}
