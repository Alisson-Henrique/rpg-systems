using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    [SerializeField]
    public Item itemInfo;

    public static System.Action<Item> AddItem;

    private Inventory _inventory;

    private void Start()
    {
        _inventory = FindObjectOfType(typeof(Inventory)) as Inventory;
    }

    public void InteractOn()
    {
        if (_inventory.AddItem(itemInfo))
        {
            AddItem?.Invoke(itemInfo);
            Destroy(this.gameObject);
        }
      
        
    }

}
