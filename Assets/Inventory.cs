using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public int capacity = 10; // Max number of items the inventory can hold

    // Adds an item to the inventory if there is space
    public bool AddItem(Item item)
    {
        if (items.Count < capacity)
        {
            items.Add(item);
            Debug.Log(item.itemName + " added to the inventory.");
            return true;
        }
        else
        {
            Debug.Log("Inventory is full.");
            return false;
        }
    }

    // Removes an item from the inventory
    public void RemoveItem(Item item)
    {
        items.Remove(item);
        Debug.Log(item.itemName + " removed from the inventory.");
    }
}
