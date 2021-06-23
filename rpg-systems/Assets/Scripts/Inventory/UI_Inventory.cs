using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Inventory : MonoBehaviour
{
    
    public ItemReference _itemObject;

    private Inventory _inventory;

    public TMP_Text _ItemNameUI;

    public TMP_Text _ItemDescriptionUI;


    void Start()
    {
        _inventory = FindObjectOfType(typeof (Inventory)) as Inventory;
        InstantiateItems();
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
        _ItemNameUI.text = reference._Item._itemName;
        _ItemDescriptionUI.text= reference._Item._description;

    }


}
