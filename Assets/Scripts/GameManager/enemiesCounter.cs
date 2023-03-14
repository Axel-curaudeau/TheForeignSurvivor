using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemiesCounter : MonoBehaviour
{
    public static int enemiesCount = 0;

    public static void addEnemy()
    {
        enemiesCount++;
    }

    public static void removeEnemy()
    {
        enemiesCount--;
    }

    private void Update()
    {
        gameObject.GetComponent<Text>().text = "enemies alive : " + enemiesCount.ToString();
    }
}
