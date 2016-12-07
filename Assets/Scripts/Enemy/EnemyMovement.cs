using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private float movex;
    private Rigidbody2D rb2d;
    private IEnumerator coroutine;  

    void Start()
    {
        movex = 2f;
        rb2d = GetComponent<Rigidbody2D>();

        coroutine = WaitAndPrint(1.5f);
        StartCoroutine(coroutine);
    }

    void Update()
    {
        rb2d.velocity = new Vector2(movex, rb2d.velocity.y);
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            movex *= -1;
        }
    }

}
