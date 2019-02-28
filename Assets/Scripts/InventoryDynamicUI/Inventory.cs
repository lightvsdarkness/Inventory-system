using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryIG {
    public class Inventory : MonoBehaviour {
        [SerializeField] private bool _displayed;

        public List<InventoryItem> Items = new List<InventoryItem>();

        public GameObject InventoryUIContainer;
        public InventoryUI InventoryUIPrefab;
        private InventoryUI InventoryUIInstance;

        public delegate void InventoryDelegate(Inventory item);

        public static event InventoryDelegate OnChanged;

        private void Start() {

        }

        public void TryToDisplay() {
            if (!_displayed) {
                if (InventoryUIContainer != null)
                    InventoryUIInstance =
                        (InventoryUI) GameObject.Instantiate(InventoryUIPrefab, InventoryUIContainer.transform);
                else
                    InventoryUIInstance = (InventoryUI) GameObject.Instantiate(InventoryUIPrefab);
                InventoryUIInstance.Construct(this);
                _displayed = true;
            }
            else {
                Destroy(InventoryUIInstance.gameObject);
                //InventoryUIPrefab = null;
                _displayed = false;
            }
        }

        //[ContextMenu("ResetItems")]
        //public void ResetItems() {
        //    Debug.Log("Items are resetting");
        //}

        public void AddItem(InventoryItem item) {
            if (item == null) return;
            Items.Add(item);
            if (OnChanged != null)
                OnChanged.Invoke(this);
        }

        public void RemoveItem(InventoryItem item) {
            if (item == null || !Items.Contains(item))
                return;

            Items.Remove(item);
            if (OnChanged != null)
                OnChanged.Invoke(this);
        }
    }
}