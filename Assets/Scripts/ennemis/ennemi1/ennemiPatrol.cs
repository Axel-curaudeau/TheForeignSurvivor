using UnityEngine;

public class ennemiPatrol : MonoBehaviour
{
    public float speed;
    public SpriteRenderer spriteRenderer;

    private Transform target;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector2 direction = (target.position - transform.position).normalized;
        rb.velocity = direction * speed;
        
    }


}
