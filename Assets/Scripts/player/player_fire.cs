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
                shoot(Vector2.left, transform.position, Inventory.instance.getSelectedItem());
                coolDown = coolDownValue;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                shoot(Vector2.right, transform.position, Inventory.instance.getSelectedItem());
                coolDown = coolDownValue;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                shoot(Vector2.up, transform.position, Inventory.instance.getSelectedItem());
                coolDown = coolDownValue;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                shoot(Vector2.down, transform.position, Inventory.instance.getSelectedItem());
                coolDown = coolDownValue;
            }
        }
        else{
            coolDown--;
        }

        



    }

    public void shoot(Vector2 direction, Vector2 position, Weapon gun)
    {
        if (gun == null)
        {
            return;
        }
        GameObject newProjectile = Instantiate(gun.projectile, position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = direction * gun.projectileSpeed;
    }
}
