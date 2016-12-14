using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed;
    private float jumpHeight;
    public Rigidbody2D rb2d;
    private float movex;
    [HideInInspector]public bool falling;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        jumpHeight = 5f;
        movex = 0f;
        falling = false;
    }

    void Update()
    {
        movex = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(movex * moveSpeed, rb2d.velocity.y);
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!falling)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
                falling = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(1,1,1);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            falling = false;
        }
    }
}