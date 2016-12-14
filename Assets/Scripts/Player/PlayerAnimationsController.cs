using UnityEngine;
using System.Collections;

public class PlayerAnimationsController : MonoBehaviour
{

    private PlayerRoar playerRoar;
    private PlayerHealth playerHealth;

    void Start()
    {
        playerRoar = GetComponent<PlayerRoar>();
        playerHealth = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (playerRoar.roaring == true)
        {
            GetComponent<Animation>().Play("Roar");
            playerRoar.roaring = false;
        }
        if (playerHealth.hurting == true)
        {
            GetComponent<Animation>().Play("Hurt");
            playerHealth.hurting = false;
        }
    }
	
}
