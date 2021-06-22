using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private GameObject bottonInteractOn;

    [SerializeField]
    private DialogueContainer dialogues;

    private DialogueManager dialogueManager;

    private void Start()
    {
        dialogueManager = FindObjectOfType(typeof(DialogueManager)) as DialogueManager;
    }

    public void InteractOn()
    {
        dialogueManager.SetConversation(dialogues); 
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bottonInteractOn.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        bottonInteractOn.SetActive(false);
    }
}
