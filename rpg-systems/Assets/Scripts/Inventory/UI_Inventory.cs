using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Inventory : MonoBehaviour
{
    
    public ItemReference _itemObject;

    public ItemReference itemTarget;

    private Inventory _inventory;

    public TMP_Text _ItemNameUI;

    public TMP_Text _ItemDescriptionUI;

    public GameObject itemWorld;

    public Transform playerPosition;

    void Start()
    {
        _inventory = FindObjectOfType(typeof (Inventory)) as Inventory;
        InstantiateItems();
        ItemReference.UpdateItemInformation += UpdateItemInformation;
        ItemWorld.AddItem += AddItem;
    }

    public void InstantiateItems()
    {

        for(int i = 0; i < _inventory.ItemsCount(); i++)
        {

            (Instantiate(_itemObject, transform) as ItemReference).SetValues(_inventory.GetItems()[i]);

        }

    }

    public void UpdateItemInformation(ItemReference reference)
    {
        itemTarget = reference;

        _ItemNameUI.text = reference._Item._itemName;
        _ItemDescriptionUI.text= reference._Item._description;

        
    }

    public void AddItem(Item item)
    {
        (Instantiate(_itemObject, transform) as ItemReference).SetValues(item);
        

    }

    public void DropItem()
    {
        if (_itemObject != null)
        {
  
            _inventory.RemoveItem(itemTarget._Item);

            GameObject temp = Instantiate(itemWorld, playerPosition.position,playerPosition.localRotation);
            temp.GetComponent<ItemWorld>().itemInfo = itemTarget._Item;
            Destroy(itemTarget.gameObject);
        }
    }

}
