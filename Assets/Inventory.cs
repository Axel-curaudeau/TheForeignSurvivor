using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject selecedItem;
    public List<GameObject> itemList;
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
        itemList = new List<GameObject>();
    }

    public void addItem(GameObject item)
    {
        if (itemList.Count >= maxItems)
        {
            removeItem(selecedItem);
        }
        itemList.Add(item);
        selecedItem = item;
        //Destroy(item);
    }

    public void removeItem(GameObject item)
    {
        Debug.Log(item);
        Instantiate(item);
        itemList.Remove(item);
    }
}
