using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryRenderUI : MonoBehaviour
{
    public GameObject ItemImage;

    public void setItemImage(Image image)
    {
        GetComponentInChildren<Image>().sprite = image.sprite;
    }
}
