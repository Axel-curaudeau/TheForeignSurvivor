using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float speed;

    public Rigidbody2D rb;

    public Vector2 movement;

    public Animator animator;

    public SpriteRenderer spriteRenderer;

    public static player_movement instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("There is more than one instance of player_movement in the scene!");
            return;
        }
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetKey(KeyCode.D) ? 1 : Input.GetKey(KeyCode.A) ? -1 : 0;
        movement.y = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
    }

    void FixedUpdate()
    {
       
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        // Set the bool to true if we are moving in any position.
        // The expression "movement.x != 0 || movement.y != 0" is a boolean expression that will be true
        //      if either x or y is not 0. If both are 0, then the expression will be false.
        animator.SetBool("isRunning", movement.x != 0 || movement.y != 0);

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
