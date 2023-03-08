using Unity.VisualScripting;
using UnityEngine;

public class Ennemi2Patrol : MonoBehaviour
{
    public int speed;
    public SpriteRenderer sprite;
    private Rigidbody2D rb;

    private Vector3 target; //Where the ennemi will go 

    // Start is called before the first frame update
    void Start()
    {
        chosePosition();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Mathf.Abs(transform.position.x - target.x) + Mathf.Abs(transform.position.y - target.y);
        if (distance !=0 )
        {
            Vector3 direction = (target - transform.position).normalized;
            rb.velocity = direction * speed;
            
        }
    }

    private void chosePosition()
    {
        float x = Random.Range(-95f, 97f);
        float y = Random.Range(-46f, 43f);

        target = new Vector3 (x, y, 0);
    }
}
