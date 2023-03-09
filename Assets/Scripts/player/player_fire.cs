using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_fire : MonoBehaviour
{
    public GameObject Bullet;
    public int coolDownValue;
    public int coolDown;
    public int bulletSpeed;

    void FixedUpdate()
    {
        if (coolDown <= 0)
        {
            if (Inventory.instance.getSelectedItem() == null)
            {
                return;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                attack(Vector2.left, transform.position, Inventory.instance.getSelectedItem());
                coolDown = Inventory.instance.getSelectedItem().attackSpeed;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                attack(Vector2.right, transform.position, Inventory.instance.getSelectedItem());
                coolDown = Inventory.instance.getSelectedItem().attackSpeed;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                attack(Vector2.up, transform.position, Inventory.instance.getSelectedItem());
                coolDown = Inventory.instance.getSelectedItem().attackSpeed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                attack(Vector2.down, transform.position, Inventory.instance.getSelectedItem());
                coolDown = Inventory.instance.getSelectedItem().attackSpeed;
            }
        }
        else{
            coolDown--;
        }
    }

    public void attack(Vector2 direction, Vector2 position, Weapon weapon)
    {
        if (weapon == null)
        {
            return;
        }
        if (weapon.name == "Gun")
        {
            GameObject newProjectile = Instantiate(weapon.projectile, position, Quaternion.identity);
            newProjectile.GetComponent<Rigidbody2D>().velocity = direction * weapon.projectileSpeed;
        }
        else if (weapon.name == "Sword")
        {
            player_movement playermovementScript = transform.GetComponent<player_movement>();
            GameObject Sword = Instantiate(weapon.projectile, position + new Vector2(0, -1.5f) + (2 * direction), Quaternion.identity);
            Sword.GetComponent<SwordAttackFollowPlayer>().setPlayerAndDirection(transform.gameObject, direction);
            
            Sword.GetComponent<Sword>().Attack(direction);
        }
    }
}
