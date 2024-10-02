using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float jumpForce = 10f;
    public Transform groundCheckPoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    public AudioClip jump;
    AudioSource playerSFX;

    Animator anim;

    private Rigidbody2D rb;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Constant Forward movement
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        // jumping logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            playerSFX.PlayOneShot(jump);
            Jump();
        }

        if (isGrounded)
        {
            anim.SetBool("IsGrounded", true);
        }
        if (isGrounded == false)
        {
            anim.SetBool("IsGrounded", false);
        }






    }






    private void Jump()
    {
        // Add an upward force for jumping
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }

}