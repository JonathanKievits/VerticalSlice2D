using UnityEngine;
using System.Collections;

public class Hanging : MonoBehaviour {

    private PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ledge")
        {
            playerMovement.rb2d.isKinematic = true;
            playerMovement.falling = false;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Ledge")
        {
            playerMovement.rb2d.isKinematic = false;
            playerMovement.falling = true;
        }
    }
}
