using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed;
    private float jumpHeight;
    public Rigidbody2D rb2d;
    private float movex;
    [HideInInspector]public bool falling;
    [HideInInspector]public bool running;
    [HideInInspector]public bool jumping;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        jumpHeight = 6f;
        movex = 0f;
        falling = false;
        running = false;
        jumping = false;
    }

    void Update()
    {
        movex = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(movex * moveSpeed, rb2d.velocity.y);
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!falling)
            {
                jumping = true;
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
                falling = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            running = false;
            running = true;
            transform.localScale = new Vector3(-1,1,1);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            running = false;
        }
        else
        if (Input.GetKeyUp(KeyCode.D))
        {
            running = false;
        }
        else
        if (Input.GetKeyDown(KeyCode.D))
        {
            running = false;
            running = true;
            transform.localScale = new Vector3(1,1,1);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            falling = false;
            jumping = false;
        }
    }
}