using UnityEngine;

public class ennemiPatrol : MonoBehaviour
{
    public float speed;
    public SpriteRenderer spriteRenderer;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
