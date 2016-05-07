using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Not used in real code. Merely a template to copy and paste from when creating new nodes.
public class SelectIdeaNode : Node
{
    public string correct_answer;

    public ConversationManager Correct_Conversation;
    public ConversationManager Incorrect_Conversation;

    bool running = false;

    public override void Run_Node()
    {
        running = true;
        UIManager.ui_manager.Select_Ideas_Button.gameObject.SetActive(true);
        UIManager.ui_manager.current_idea_node = this;
        //UIManager.ui_manager.selected_idea = "";
    }


    public void IdeaSelected(string idea)
    {
        running = false;
        UIManager.ui_manager.Ideas.SetActive(false);
        UIManager.ui_manager.Select_Ideas_Button.gameObject.SetActive(false);

        if (idea == correct_answer)
        {
            Correct_Conversation.Start_Conversation();
        }
        else
        {
            Incorrect_Conversation.Start_Conversation();
        }

        this.transform.GetComponentInParent<ConversationManager>().Finish_Conversation();
    }


    public override void Button_Pressed()
    {
        
    }


    public override void Finish_Node()
    {
        StopAllCoroutines();

        base.Finish_Node();
    }

    void Update()
    {
        if (running)
        {
            UIManager.ui_manager.Ideas.SetActive(true);
        }
    }
}
