using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    
    public Message[] messages;
    public Actor[] actors;

    public void startDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
    }

}


[System.Serializable]
public class Message{

    public int actorid;
    [TextArea(3, 10)]
    public string message;
}

[System.Serializable]
public class Actor
{

    public string Name;
    public Sprite sprite;

}
