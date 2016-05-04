using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Not used in real code. Merely a template to copy and paste from when creating new nodes.
public class PinkyFriendsNode : Node
{
    public ConversationManager not_friends_with_pinky_convo;
    public ConversationManager friends_with_pinky_convo;

    public override void Run_Node()
    {
        if (NimosStats.stats.Pinkerton_Relationship > 0)
        {
            friends_with_pinky_convo.Start_Conversation();
        }
        else
        {
            not_friends_with_pinky_convo.Start_Conversation();
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
}
