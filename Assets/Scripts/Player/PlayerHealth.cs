using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    [HideInInspector]public float playerHealth;

	void Start ()
    {
        playerHealth = 100f;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if(other.tag == "Danger")
        {
            if (playerHealth > 1)
            {
                playerHealth -= 25f;
            }
            else if(playerHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
