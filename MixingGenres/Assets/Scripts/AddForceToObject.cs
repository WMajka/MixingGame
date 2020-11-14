using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToObject : MonoBehaviour
{
    [SerializeField] Rigidbody2D GetRigidbody2D;
    [SerializeField] private float TimeToDestory;
    [SerializeField] private float Power;
    [SerializeField] private bool isItBullet;
    private void Awake()
    {
        GetRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        if (isItBullet)
        {
            GetRigidbody2D.AddRelativeForce(Vector2.up * Power, ForceMode2D.Impulse);
            Destroy(gameObject, TimeToDestory);
        }
        else
        {
            GetRigidbody2D.AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * Power, ForceMode2D.Impulse);
            GetRigidbody2D.AddTorque(Random.Range(-20.0f, 20.0f));
        }
    }
}
