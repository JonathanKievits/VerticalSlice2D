using UnityEngine;
using System.Collections;

public class KnockBack : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float kbForce;
    private float dmgKb;
    private EnemyMovement enemyMovement;

    void Start()
    {
        enemyMovement = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyMovement>();
        kbForce = 30000f;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dmgKb = kbForce * enemyMovement.direction;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            rb2d.AddForce(new Vector2(0f, 5000f));
        }
        if(other.tag == "Danger")
        {
            rb2d.AddForce(new Vector2(dmgKb,1500f));
        }

    }
}