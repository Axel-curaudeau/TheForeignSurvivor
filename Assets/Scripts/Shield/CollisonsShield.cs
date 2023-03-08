using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonsShield : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "ennemiBullet")
        {
            Destroy(other.gameObject);
        }
    }
}
