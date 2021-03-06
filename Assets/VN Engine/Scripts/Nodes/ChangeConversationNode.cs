using UnityEngine;
using System.Collections;

public class ChangeConversationNode : Node 
{
	public ConversationManager conversation_to_start;

	public override void Run_Node()
	{
        StartCoroutine(Check_If_Actors_Have_Exited());
        //StartNewConversation();
	}
	
    IEnumerator Check_If_Actors_Have_Exited()
    {
        while (ActorManager.exiting_actors.Count > 0)
        {
            yield return new WaitForSeconds(0.1f);
        }

        StartNewConversation();
        yield break;
    }
	
    public void StartNewConversation()
    {
        if (UIManager.ui_manager.speaker_text_panel)
        {
            UIManager.ui_manager.speaker_text_panel.text = "";
            UIManager.ui_manager.dialogue_text_panel.text = "";
        }

        conversation_to_start.Start_Conversation();
        this.transform.GetComponentInParent<ConversationManager>().Finish_Conversation();

//        Finish_Node();
    }

    public override void Button_Pressed()
	{

	}
	
	
	public override void Finish_Node()
	{
        StopAllCoroutines();
		
		base.Finish_Node();
	}
}
