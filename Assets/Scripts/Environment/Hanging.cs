using UnityEngine;
using System.Collections;

public class Hanging : MonoBehaviour {

    private PlayerMovement playerMovement;
    [HideInInspector]public bool hangingOn;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        hangingOn = false;
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ledge")
        {
            playerMovement.rb2d.isKinematic = true;
            playerMovement.falling = false;
            playerMovement.jumping = false;
            hangingOn = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Ledge")
        {
            playerMovement.rb2d.isKinematic = false;
            playerMovement.falling = true;
            hangingOn = false;
        }
    }
}
