using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected Transform player;

    private protected Rigidbody2D rb;
    private protected Vector2 movement;

    public float speed;
    public int health;

    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector2.down * speed;
    }

    void OnHit(int dmg)
    {
        health -= dmg;

        if (health <= 0)

        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BorderBullet")
        {
            Destroy(gameObject);
        } 
        else if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }
}

public class EnemyYul : Enemy
{

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }
    private void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
