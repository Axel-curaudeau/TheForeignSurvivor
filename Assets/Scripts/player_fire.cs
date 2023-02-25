using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_fire : MonoBehaviour
{
    public GameObject Bullet;
    public int coolDownValue;
    public int coolDown;
    public int bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (coolDown <= 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                newBullet(Vector2.left);
                coolDown = coolDownValue;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                newBullet(Vector2.right);
                coolDown = coolDownValue;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                newBullet(Vector2.up);
                coolDown = coolDownValue;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                newBullet(Vector2.down);
                coolDown = coolDownValue;
            }
        }
        else{
            coolDown--;
        }

        



    }
    
    void newBullet(Vector2 Direction)
    {
        {
            GameObject newBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody2D>().velocity = transform.localScale * Direction * bulletSpeed;
        }
    }
}
