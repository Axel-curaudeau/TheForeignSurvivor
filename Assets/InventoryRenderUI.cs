using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotRenderUI : MonoBehaviour
{
    public GameObject ItemImage;

    public void setItemImage(Sprite image)
    {
        Debug.Log(image.ToString() + ItemImage.ToString());
        ItemImage.SetActive(true);
        ItemImage.GetComponent<Image>().sprite = image;
    }
}
