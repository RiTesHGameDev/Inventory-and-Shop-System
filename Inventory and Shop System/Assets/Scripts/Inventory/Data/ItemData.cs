using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public string description;

    public ItemType type;
    public ItemRarity rarity;

    public int buyPrice;
    public int sellPrice;

    public float weight;
}
