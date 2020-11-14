using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer GetSpriteRenderer;
    [SerializeField] private CircleCollider2D GetCircleCollider2D;
    [SerializeField] Match3 GetMatch3;
    public Color colorToChange;
    [SerializeField] private LiveSystem GetLiveSystem;
    private void Start()
    {
        GetSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        GetMatch3 = GameObject.Find("GameManager").GetComponent<Match3>();
        GetLiveSystem = GameObject.Find("GameManager").GetComponent<LiveSystem>();
        GetCircleCollider2D = gameObject.GetComponent<CircleCollider2D>();
        StartCoroutine(activeCollider());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            ChangeColorForEnemy(colorToChange, GetSpriteRenderer);
            DestroyBullet(collision);
        }
        if (collision.tag == "Player")
        {
            GetLiveSystem.RemoveLive();
            GetLiveSystem.RestartPlayer();
        }
    }

    private void AddToDestroyList()
    {
        GetMatch3.AddToList(gameObject);
    }

    private void ChangeColorForEnemy(Color color, SpriteRenderer spriteRenderer)
    {
        spriteRenderer.color = color;
        AddToDestroyList();
    }
    IEnumerator activeCollider()
    {
        yield return new WaitForSeconds(0.5f);
        GetCircleCollider2D.enabled = true;
    }
    private void DestroyBullet(Collider2D collider)
    {
        if (collider.tag == "Bullet")
        {
            Destroy(collider.gameObject);
        }
    }
}
