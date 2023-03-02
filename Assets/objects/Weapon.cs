using System.Data;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Inventory/Weapon")]
public class Weapon : ScriptableObject
{
    public int id;
    public int damage;
    public float attackSpeed;
    public int durability;
    public Sprite image;
    public string title;
    public string description;
    public GameObject projectile;
}
