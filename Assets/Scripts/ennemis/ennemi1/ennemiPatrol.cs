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
        target = GameObject.FindWithTag("Player").GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
