using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsManager : MonoBehaviour
{
    public GameObject inventoryPanel;

    private bool pause = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && pause == false)
        {
            inventoryPanel.SetActive(true);
            pause = true;
        }
        else if(Input.GetKeyDown(KeyCode.Tab) && pause == true)
        {
            inventoryPanel.SetActive(false);
            pause = false;
        }
        


    }
}
