using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Weapon selecedItem;
    public List<Weapon> itemList;
    public int maxItems = 1;

    public static Inventory instance;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found");
            return;
        }
        instance = this;
    }

    public Inventory()
    {
        itemList = new List<Weapon>();
        selecedItem = null;
    }

    public void addItem(GameObject item)
    {
        if (itemList.Count >= maxItems)
        {
            //removeItem(selecedItem);
        }

        Weapon itemToStore = item.GetComponent<Gun>().GunData;

        itemList.Add(itemToStore);
        if (selecedItem == null)
        {
            selecedItem = itemToStore;
        }
        Destroy(item);
    }

    public void removeItem(Weapon item)
    {
        Debug.Log(item);
        itemList.Remove(item);
    }

    public Weapon getSelectedItem()
    {
        return selecedItem;
    }
}
