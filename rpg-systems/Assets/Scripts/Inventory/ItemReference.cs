using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemReference : MonoBehaviour
{
    public Image _icon;
    private int id;
    public Button button;

    public static System.Action<ItemReference> UpdateItemInformation;

    public Item _Item { get; private set; }

    public void SetValues(Item item)
    {
        _Item = item;
        _icon.sprite = item._icon;
        id = item._id;
    }

    private void Start()
    {
        UpdatePanelItem();
        button = GetComponent<Button>();
        button.onClick.AddListener(UpdatePanelItem);
    }
    void UpdatePanelItem()
    {
        UpdateItemInformation?.Invoke(this);
    }
}
