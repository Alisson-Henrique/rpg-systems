using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item", fileName ="Item")]
public class Item : ScriptableObject
{
    public int _id;

    public string _itemName;

    public Sprite _icon;

    public string _description;



}
