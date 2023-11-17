using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue() 
    {
      //  FindObjectOfType<DialogManager>().StartDialogue(dialogue);
        Object.FindFirstObjectByType<DialogManager>().StartDialogue(dialogue); 
    }
}
