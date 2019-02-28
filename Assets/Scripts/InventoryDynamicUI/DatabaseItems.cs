using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace InventoryIG {

    [System.Serializable]
    [CreateAssetMenu(fileName = "DatabaseItem.asset", menuName = CreateAssetMenuPath + "Database Item")]
    public class DatabaseItem : ScriptableObject {
        public const string CreateAssetMenuPath = "Inventory/";

        [Header("Items")]
        public InventoryItem[] items = new InventoryItem[0];
        public ItemRarity[] rarities = new ItemRarity[0];
        public ItemCategory[] categories = new ItemCategory[0];

        [Header("Crafting")]
        public CraftingCategory[] craftingCategories = new CraftingCategory[0];
        }
}