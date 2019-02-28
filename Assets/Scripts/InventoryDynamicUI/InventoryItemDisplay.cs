using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[ExecuteInEditMode]
public class InventoryItemDisplay : MonoBehaviour
{
    public Text TextName;
    public Image Image;

    [Tooltip("Do not set manually")]
    public InventoryItem Item;
    //public bool Constructed;

    public delegate void InventoryItemDisplayDelegate(InventoryItem item);
    public static event InventoryItemDisplayDelegate OnClick;

    [ContextMenu("Start")]
	void Start () {
		if(Item != null)    // !Constructed && 
            Construct(Item);
	}
	void Update () {
		
	}

    public void Construct(InventoryItem item)
    {
        Item = item;
        if(item == null)
        { 
            if (TextName != null)
                TextName.text = "";
            if (Image != null)
                Image.sprite = null;
                //Constructed = true;
            return;
        }
        if (TextName != null)
            TextName.text = item.DisplayName;
        if (Image != null)
            Image.sprite = item.Sprite;
        //Constructed = true;
    }

    public void Click()
    {
        // Debug stuff
        string displayName = "nothing";
        if (Item != null)
            displayName = Item.DisplayName;
        Debug.Log("Clicked on " + displayName);


        if (OnClick != null && Item != null)
        {
            OnClick.Invoke(Item);
            
        }
        else if (Item != null)
        {
            Debug.Log("Nobody was lstening to " + Item.DisplayName);
        }
    }
}
