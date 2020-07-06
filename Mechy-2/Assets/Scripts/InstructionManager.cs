using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class InstructionManager : MonoBehaviour
{   
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI instructionText;
    public GameObject InstructionDisplay;
    public GameObject[] pointers;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartInstruction (Instruction instruction)
    {
        nameText.text = instruction.name;
        titleText.text = instruction.title;

        sentences.Clear();

        foreach (string sentence in instruction.sentences)
        {
           ;
            
            sentences.Enqueue(sentence);
        }
         Debug.Log("loaded : " + sentences);
         DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        Debug.Log("clicked continue button");
        if (sentences.Count == 0)
        {
            Debug.Log("exiting dialog");
            EndInstruction();
            return;
        }
        Debug.Log("printing dialog");

        string sentence = sentences.Dequeue();
        instructionText.text = sentence;
        Debug.Log("printed dialog");
    }

    public void EndInstruction()
    {
        InstructionDisplay.SetActive(false);
        UnHideObjects ();
        Debug.Log("exited dialog");

    }
    void UnHideObjects ()
    {
        foreach (GameObject obj in pointers)
        {
            obj.SetActive(true);
        }
    }

   
}
