using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    [HideInInspector]
    public float currentHealth;
    [HideInInspector]
    public bool hurting = false;

    void Start()
    {
        currentHealth = 100;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Border")
        {
            SceneManager.LoadScene(1);
        }
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Danger")
        {
            if ( currentHealth >= 30)
            {
                StartCoroutine("HurtingInAction");
                currentHealth -= 25;
                hurting = true;
            }
            else if (currentHealth <= 30)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    void Update()
    {
        if (currentHealth > 100)
        {
            currentHealth = 100f;
        }

    }

    IEnumerator HurtingInAction()
    {
        yield return new WaitForSeconds(4f);
        hurting = false;
        StopCoroutine("HurtingInAction");
    }
}
