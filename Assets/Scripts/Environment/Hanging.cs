using UnityEngine;
using System.Collections;

public class Hanging : MonoBehaviour {

    private PlayerMovement playerMovement;
    private Rigidbody2D rb2d;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        rb2d = GetComponent<Rigidbody2D>();
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ledge")
        {
            rb2d.gravityScale = 0;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Ledge")
        {
            rb2d.gravityScale = 1;
        }
    }

}
