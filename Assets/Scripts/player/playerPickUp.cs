using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerPickUp : MonoBehaviour
{
    bool isOnItem = false;
    public GameObject itemOn = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            isOnItem = true;
            itemOn = collision.gameObject;
        }
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Inventory.instance.nextItem();
            Inventory.instance.GetComponent<SlotRenderUI>().changeSlot();
        }
        if (isOnItem)
        {
            if (itemOn.name.Split(':')[0] == "Heart")
            {
                if (GetComponent<infosPlayer>().addHP(20))
                {
                    Destroy(itemOn);
                    itemOn = null;
                }
            }

            else if (Input.GetKeyDown(KeyCode.E))
            {
                Inventory.instance.addItem(itemOn);
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == itemOn)
        {
            isOnItem = false;
            itemOn = null;
        }
    }
}
