using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Image actorImage;
    public Text actorName; 
    public Text messageText;
    public RectTransform backgroundBox;

    public Animator animator;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;
    public void OpenDialogue(Message[] message, Actor[] actors)
    {
        animator.SetBool("isOpen",true);
        currentActors = actors;
        currentMessages = message;
        activeMessage = 0;
        DisplayMessage();
        isActive = true;
        Debug.Log("StartIng  Chats!! : " + message.Length);
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorid];
        actorName.text = actorToDisplay.Name;
        actorImage.sprite = actorToDisplay.sprite;
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();

        }
        else
        {
            Debug.Log("Chat End!");
            isActive = false;
            animator.SetBool("isOpen", false);
        }

       
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive ==true )
        {
            NextMessage();
        }
    }
}
