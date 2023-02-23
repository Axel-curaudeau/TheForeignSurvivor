using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float speed = 10f;

    public Rigidbody2D rb;

    public Vector2 movement;

    public Animator animator;

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        
        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        //flip
        if (movement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
