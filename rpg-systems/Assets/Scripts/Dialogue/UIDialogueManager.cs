using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDialogueManager : MonoBehaviour
{
  
    public GameObject UIContainer;
    public Sprite _characterimage;
    public TMP_Text _nameCharacter;
    public TMP_Text _dialogue;


    private void Awake()
    {
        DialogueManager.NextTalker += NextTalker;
        DialogueManager.ResetText += ResetText;
        DialogueManager.ShowMenssage += ShowMenssage;
        DialogueManager.UiContainerState += UiContainerState;
    }
    void OnDestroy()
    {
        DialogueManager.NextTalker -= NextTalker;
        DialogueManager.ResetText -= ResetText;
        DialogueManager.ShowMenssage -= ShowMenssage;
        DialogueManager.UiContainerState -= UiContainerState;
    }


    private void NextTalker(Dialogue dialogue)
    {
        _characterimage = dialogue._character._sprite;
        _nameCharacter.text = dialogue._character._characterName;


    }

    private void ShowMenssage(string sentence) => 
        _dialogue.text = sentence;

    private void ResetText() => 
        _dialogue.text = string.Empty;

    private void UiContainerState(bool state) => UIContainer.SetActive(state);
}
