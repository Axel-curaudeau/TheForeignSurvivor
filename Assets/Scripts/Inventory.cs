using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject selecedItem;
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
    }

    public void addItem(GameObject item)
    {
        if (itemList.Count >= maxItems)
        {
            //removeItem(selecedItem);
        }
        Weapon itemToStore = null;
        if (item.name.Split(':')[0] == "Gun")
        {
            itemToStore = ScriptableObject.CreateInstance<Weapon>();
        }
        else
        {
            Debug.LogWarning("Item unknown");
            return;
        }
        itemToStore.name = item.name;

        itemList.Add(itemToStore);
        Destroy(item);
    }

    public void removeItem(Weapon item)
    {
        Debug.Log(item);
        itemList.Remove(item);
    }
}
