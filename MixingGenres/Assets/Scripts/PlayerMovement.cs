using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D GetPlayerRigidbody2D;
    [SerializeField] private InputFromPlayer GetInput;
    [SerializeField] private float PlayerSpeed;
    [SerializeField] private float PlayerSpeedRotation;

    private void FixedUpdate()
    {
        PlayerMove();
        PlayerRotation();
    }

    private void PlayerMove()
    {
        GetPlayerRigidbody2D.AddRelativeForce(new Vector2(0.0f, GetInput.GetForce) * Time.deltaTime * PlayerSpeed);
    }
    private void PlayerRotation()
    {
        gameObject.transform.Rotate(new Vector3(0.0f,0.0f, 1.0f), GetInput.GetRotation * Time.deltaTime * PlayerSpeedRotation);
    }
}
