using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    [HideInInspector]
    public float currentHealth;

    void Start()
    {
        currentHealth = 100;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Danger")
        {
            if ( currentHealth > 1)
            {
                currentHealth -= 20;
            }
            else if (currentHealth < 20)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene(0);

            }
        }
    }

    void Update()
    {
        if (currentHealth > 100)
        {
            currentHealth = 100f;
        }

       // Debug.Log(currentHealth);

    }
}
