using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
    public GameObject player;
    public Slider slider;

    private PlayerHealth playerHealth;

	void Start ()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        slider.value = (playerHealth.currentHealth - 0)/(100 - 0);
	}
}
