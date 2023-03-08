using System.Data;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Weapon", menuName = "Inventory/Weapon")]
public class Weapon : ScriptableObject
{
    public int id;
    public int damage;
    public int attackSpeed;
    public int durability;
    public float projectileSpeed;
    public Sprite image;
    public string title;
    public string description;
    public GameObject projectile;
}
