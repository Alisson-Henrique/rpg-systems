using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemReference : MonoBehaviour
{
    public Image _icon;

    public Item _Item { get; private set; }

    public void SetValues(Item item)
    {
        _Item = item;
        _icon.sprite = item._icon;
    }

}
