using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace InventoryIG
{
    [System.Serializable]
    public partial class CraftingCategory : ScriptableObject
    {
        [HideInInspector]
        public int ID;

        public new string name;
        public string description;
        public Sprite icon;

        /// <summary>
        /// Also scan through the bank for items to use when crafting the item.
        /// </summary>
        public bool alsoScanBankForRequiredItems = false;

        public uint rows = 3;
        public uint cols = 3;

        public CraftingBlueprint[] blueprints = new CraftingBlueprint[0];

        public AudioClip successAudioClip;
        public AudioClip craftingAudioClip;
        public AudioClip failedAudioClip;

        public override string ToString() {
            return name;
        }
    }
}