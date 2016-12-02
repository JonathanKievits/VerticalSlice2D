using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour
{

    private PlayerHealth pH;

    // Use this for initialization
    void Start()
    {
        pH = GetComponent<PlayerHealth>();
        Debug.Log(pH);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HealthPickup")
        {
            pH.currentHealth += 20f;
            Destroy(other.gameObject);
            Debug.Log("Fuck you boyye");
        }

    }
}
