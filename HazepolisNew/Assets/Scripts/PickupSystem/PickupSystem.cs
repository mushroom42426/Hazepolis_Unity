using Inventory.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSystem : MonoBehaviour
{
    [SerializeField]
    private InventorySO inventoryData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ItemOld item = collision.GetComponent<ItemOld>();
        if (item != null)
        {
            int reminder = inventoryData.AddItem(item.InventoryItem, item.Quantity);
            if (reminder == 0)
                item.DestroyItem();
            else
                item.Quantity = reminder;
        }
    }
}
