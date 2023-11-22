using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject interactButton;
    public GameObject Interactable;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Assuming the Detective is tagged as "Player"
        {
            TriggerDialogue();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interactButton.SetActive(false); // Hide the interact button
        }
    }
    public void TriggerDialogue() 
    {
      //  FindObjectOfType<DialogManager>().StartDialogue(dialogue);
        Object.FindFirstObjectByType<DialogManager>().StartDialogue(dialogue); 
    }
    public void TriggerInteraction()
    {
        bool isCurrentlyActive = Interactable.activeSelf;
        Interactable.SetActive(!isCurrentlyActive); // Toggle the active state

        // Optionally trigger something in the dialogue manager
        FindObjectOfType<DialogManager>().HandleInteraction("newspaper", !isCurrentlyActive);
    }

}
