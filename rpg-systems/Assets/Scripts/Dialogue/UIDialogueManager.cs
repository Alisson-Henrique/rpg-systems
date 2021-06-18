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

    private void showDialogue(string sentence) => 
        _dialogue.text = sentence;

    private void restDialogue() => 
        _dialogue.text = string.Empty;

    private void UiContainerState(bool state) => UIContainer.SetActive(state);
}
