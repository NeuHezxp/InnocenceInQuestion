using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {
    public Text nameText;
    public Text dialogueText;
    public GameObject dialogueBox; // Reference to the dialogue box GameObject


    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartDialogue(Dialogue dialogue)
    {
        dialogueBox.SetActive(true); // Show the dialogue box
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }
    void EndDialogue()
    {
        dialogueBox.SetActive(false); // Hide the dialogue box
        Debug.Log("End of Dialogue");
    }
    public void HandleInteraction(string interactionType, bool isActive)
    {
        if (interactionType == "newspaper")
        {
            // Implement whatever needs to happen in the dialogue manager
            // when the newspaper is shown or hidden
        }
    }
}
