using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    public static DialogueManager instance;

    public static event System.Action<Dialogue> NextTalker;

    public static event System.Action ResetText;

    public static event System.Action<string> ShowMenssage;

    public static event System.Action<bool> UiContainerState;

    public DialogueContainer currentDialogue;

    private bool endCurrenteTalker = true;

    private bool buttonClicked = true;

    void Awake()
    {
        instance = this;

    }
    public void SetConversation(DialogueContainer container)
    {
        currentDialogue = container;
        StartCoroutine(StartConversation());
        UiContainerState?.Invoke(true);
    }

    private IEnumerator StartConversation()
    {

        for(int i = 0;i < currentDialogue._dialogues.Length; i++)
        {
            ResetText?.Invoke();
            NextTalker?.Invoke(currentDialogue._dialogues[i]);
            StartCoroutine(ShowDialogue(currentDialogue._dialogues[i]._sentences));

            yield return new WaitUntil(() => endCurrenteTalker);
        }

        UiContainerState?.Invoke(false);
    }

    private IEnumerator ShowDialogue(string[] sentences)
    {
        endCurrenteTalker = false;

        foreach(var sentence in sentences)
        {
            yield return new WaitUntil(() => buttonClicked = true);
            ShowMenssage?.Invoke(sentence);
            buttonClicked = false;
        }

        endCurrenteTalker = true;

    }

    private void ButtonWasClicked() => 
        buttonClicked = true;
   
}
