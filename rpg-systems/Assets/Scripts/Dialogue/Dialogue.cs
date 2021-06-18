using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    [SerializeField]
    private string CharacterName;

    [TextArea]
    [SerializeField]
    private string[] sentences;

}
