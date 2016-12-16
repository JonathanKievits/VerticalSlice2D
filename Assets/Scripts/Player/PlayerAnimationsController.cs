using UnityEngine;
using System.Collections;

public class PlayerAnimationsController : MonoBehaviour
{

    private PlayerRoar playerRoar;
    private PlayerHealth playerHealth;
    private PlayerMovement playerMovement;
    private Hanging hanging;
    private Animator anim;

    void Awake()
    {
        playerRoar = GetComponent<PlayerRoar>();
        playerHealth = GetComponent<PlayerHealth>();
        playerMovement = GetComponent<PlayerMovement>();
        hanging = GetComponent<Hanging>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Debug.Log(playerMovement.jumping);
        if (playerRoar.roaring == true)
        {
            anim.SetBool("Roar", true);
            playerRoar.roaring = false;
        }
        else
        if (playerHealth.hurting == true)
        {
            anim.SetBool("Hurt", true);
            playerHealth.hurting = false;
        }
        else
        if (playerMovement.running == true && hanging.hangingOn == false && playerMovement.jumping == false)
        {
            anim.SetBool("Running", true);
        }
        else 
        if(playerMovement.running == false && playerRoar.roaring == false && hanging.hangingOn == false)
        {
            anim.SetBool("Hurt", false);
            anim.SetBool("Hanging", false);
            anim.SetBool("Roar", false);
            anim.SetBool("Running", false);
            anim.SetBool("SJump", false);
            anim.SetBool("RJump", false);
            anim.SetBool("LJump", false);
            anim.SetBool("Idle", true);
        }

        if (hanging.hangingOn == true && playerMovement.jumping)
        {
            anim.SetBool("Hanging", false);
            hanging.hangingOn = false;
            anim.SetBool("LJump", true);
        }
        else
        if (hanging.hangingOn == true)
        {
            anim.SetBool("Hanging", true);
            anim.SetBool("LGrab", true);
            anim.SetBool("Running", false);
            anim.SetBool("RJump", false);
            anim.SetBool("SJump", false);
            anim.SetBool("LJump", false);
            anim.SetBool("Idle", false);
            playerMovement.running = false;
            playerMovement.jumping = false;
        }

        if (playerMovement.jumping == true && playerMovement.running == true && hanging.hangingOn == false)
        {
            anim.SetBool("Running", false);
            anim.SetBool("RJump", true);
            playerMovement.jumping = false;
        }
        else if (playerMovement.jumping == true && playerMovement.running == false && hanging.hangingOn == false)
        {
            anim.SetBool("SJump", true);
        }
    }
}