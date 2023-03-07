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
        int direction = Random.Range(0, 4);

        if (direction == 0)
        {
            target= new Vector3(Random.Range(-31f,33f),13f,0f);
        }
        else if (direction == 1)
        {
            target = new Vector3(Random.Range(-31f, 33f), -16f, 0f);
        }
        else if (direction == 2)
        {
            target = new Vector3(33f, Random.Range(-16f, 13f), 0f);
        }
        else
        {
            target= new Vector3(-31f,Random.Range(-16f,13f),0f);
        }
    }
}
