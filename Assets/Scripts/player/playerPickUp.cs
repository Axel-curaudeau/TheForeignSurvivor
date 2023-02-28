using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colision item");
        if (collision.gameObject.tag == "Item")
        {
            Inventory.instance.addItem(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
