using UnityEngine;
using System.Collections;

public class PlayerAnimationsController : MonoBehaviour
{

    private PlayerRoar playerRoar;
    private PlayerHealth playerHealth;
    private PlayerMovement playerMovement;
    private Hanging hanging;
    private Animator anim;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        playerRoar = GetComponent<PlayerRoar>();
        playerHealth = GetComponent<PlayerHealth>();
        playerMovement = GetComponent<PlayerMovement>();
        hanging = GetComponent<Hanging>();
        anim = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();

        idle();
    }

    private void idle()
    {
        anim.SetBool("Hurt", false);
        anim.SetBool("Hanging", false);
        anim.SetBool("Roar", false);
        anim.SetBool("SJump", false);
        anim.SetBool("RJump", false);
        anim.SetBool("LJump", false);
        anim.SetBool("Idle", true);
    }

    void Update()
    {
        anim.SetFloat("Running", Mathf.Abs(rb2d.velocity.x));

        if (playerRoar.roaring == true)
        {
            anim.SetBool("Roar", true);
        }

        if (playerHealth.hurting == true)
        {
            anim.SetBool("Hurt", true);
        }

        if (playerMovement.running == false && playerRoar.roaring == false && hanging.hangingOn == false)
        {
            idle();
        }

        if (hanging.hangingOn == true && playerMovement.jumping)
        {
            anim.SetBool("Hanging", false);
            hanging.hangingOn = false;
            anim.SetBool("LJump", true);
        }

        if (hanging.hangingOn == true)
        {
            anim.SetBool("Hanging", true);
            anim.SetBool("RJump", false);
            anim.SetBool("SJump", false);
            anim.SetBool("LJump", false);
            anim.SetBool("Idle", false);
            playerMovement.running = false;
            playerMovement.jumping = false;
        }

        if (playerMovement.jumping == true && playerMovement.running && hanging.hangingOn == false)
        {
            anim.SetBool("RJump", true);
            playerMovement.jumping = false;
        }
        else if (playerMovement.jumping && playerMovement.running == false && hanging.hangingOn == false)
        {
            anim.SetBool("SJump", true);
        }
    }
}