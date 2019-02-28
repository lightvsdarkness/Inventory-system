using UnityEngine;
using System;
using System.Collections.Generic;

namespace InventoryIG {
    [System.Serializable]
    public partial class CraftingBlueprint : ScriptableObject {
        public int ID;

        public string name;
        public string description;

        /// The items required for this blueprint
        public List<InventoryItem> requiredItems = new List<InventoryItem>();
        public int CraftingCost;

        /// The item gained after crafting.
        public List<InventoryItem> resultItems = new List<InventoryItem>();

        /// Usage requirement properties. For example, the player needs at least 10 strength to craft this item.
        public int usageRequirement = 0;

        public bool BlueprintLearned = true;

        [Range(0.0f, 1.0f)]
        public float successChanceFactor = 1.0f;
    }
}