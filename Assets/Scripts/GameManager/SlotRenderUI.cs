using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SlotRenderUI : MonoBehaviour
{
    public GameObject ItemImage1;
    public GameObject ItemImage2;
    public GameObject Slot1;
    public GameObject Slot2;

    public void setItemImage(Sprite image)
    {
        if (!ItemImage1.activeSelf)
        {
            ItemImage1.SetActive(true);
            ItemImage1.GetComponent<Image>().sprite = image;
        }
        else if (!ItemImage2.activeSelf)
        {
            Slot2.SetActive(true);
            ItemImage2.SetActive(true);
            ItemImage2.GetComponent<Image>().sprite = image;
        }
        
    }

    public void changeSlot()
    {
        if (Inventory.instance.itemList.Count > 1)
        {
            if (Slot1.transform.GetChild(1).gameObject.activeSelf)
            {
                Slot1.transform.GetChild(1).gameObject.SetActive(false);
                Slot2.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (Slot2.transform.GetChild(1).gameObject.activeSelf)
            {
                Slot1.transform.GetChild(1).gameObject.SetActive(true);
                Slot2.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
