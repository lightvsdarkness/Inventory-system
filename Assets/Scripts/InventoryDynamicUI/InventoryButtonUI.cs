using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryIG {
    public class InventoryButtonUI : MonoBehaviour {

        public Inventory Inventory;
        public HeroInventory Equipment;


        public void Start() {
            if (Inventory == null)
                GetComponent<Inventory>();

        }

        public void DisplayInventoryAndEquipment() {
            DisplayInventory();
            DisplayEquipment();
        }

        public void DisplayInventory() {
            if (Inventory != null)
                Inventory.TryToDisplay();
            else if (Party.I.PartyInventory != null)
                Party.I.PartyInventory.TryToDisplay();
        }

        public void DisplayEquipment() {
            if (Equipment != null)
                Equipment.TryToDisplay();
            else if (Party.I.CurrentHeroInventory != null)
                Party.I.CurrentHeroInventory.TryToDisplay();
        }
    }
}