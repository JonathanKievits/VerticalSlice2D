using UnityEngine;
using System.Collections;

public class KnockBack : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float kbForce;
    private float dmgKb;
    private PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        kbForce = 7000f;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dmgKb = kbForce * playerMovement.direction;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            rb2d.AddForce(new Vector2(0f, 5000f));
            Debug.Log("Hello");
        }
        if(other.tag == "Danger")
        {
            rb2d.AddForce(new Vector2(dmgKb,500f));
        }

    }
}