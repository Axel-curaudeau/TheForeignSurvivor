using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Inventory.instance.addItem(collision.gameObject);
            GetComponent<player_fire>().coolDownValue = Inventory.instance.getSelectedItem().attackSpeed;
        }
    }
}
