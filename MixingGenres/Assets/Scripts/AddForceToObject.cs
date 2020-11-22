using UnityEngine;

public class AddForceToObject : MonoBehaviour
{
    [SerializeField] Rigidbody2D GetRigidbody2D;
    [SerializeField] Transform GetTransform;
    [SerializeField] private float Power;
    [SerializeField] private bool isItBullet;
    [SerializeField] private float TimeToDestory;
    private void Awake()
    {
        GetRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        GetTransform = gameObject.GetComponent<Transform>();
    }
    private void Start()
    {
        if (!isItBullet)
        {
            GetRigidbody2D.AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * Power, ForceMode2D.Impulse);
            GetRigidbody2D.AddTorque(Random.Range(-20.0f, 20.0f));
        }
        else if(isItBullet)
        {
            Destroy(gameObject, TimeToDestory);
            GetRigidbody2D.velocity = GetTransform.up * Power;
        }

    }

}
