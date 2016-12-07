using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    private float moveSpeed;
    private float jumpHeight;
    public Rigidbody2D rb2d;
    private float movex;
    [HideInInspector]public float direction;
    [HideInInspector]public bool falling;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
        jumpHeight = 7f;
        movex = 0f;
        falling = false;
        direction = 1f;
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
            direction = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = 1;
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