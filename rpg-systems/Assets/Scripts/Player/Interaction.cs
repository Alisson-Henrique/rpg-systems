using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    private bool interactOn = false;
    [SerializeField]
    private GameObject target;
    public GameObject InteractIcon;

    // Update is called once per frame
    void Update()
    {
        if (interactOn && Input.GetKeyDown(KeyCode.F) == true && target != null){ target.SendMessage("InteractOn",SendMessageOptions.DontRequireReceiver);}

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        interactOn = true;
        target = collision.gameObject;
        InteractIcon.SetActive(true);
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        interactOn = false;
        target = null;
        InteractIcon.SetActive(false);

    }
}
