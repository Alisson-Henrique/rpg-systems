using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private List<Item> items;

    [SerializeField]
    private int _capacity;

    public bool AddItem(Item item)
    {

        if(items.Count < _capacity)
        {
            items.Add(item);
            return true;
        }
        return false;
    }

    public void RemoveItem(Item item)
    {
        if(item != null)
        {
            items.Remove(item);
        }
    }

    public int ItemsCount()
    {
        return items.Count;
    }

    public List<Item> GetItems()
    {
        return items;
    }
}
