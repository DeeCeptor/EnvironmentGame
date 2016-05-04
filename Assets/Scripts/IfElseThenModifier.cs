using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IfElseThenModifier : ChoiceRequirementModifier
{
    public ConversationManager conversation_to_start_if_unlocked;
    public ConversationManager main_conversation_is_null;
    public ConversationManager conversation_if_locked;

    public override void ModifyButton(Button button)
    {
        base.ModifyButton(button);
    }

    public void Unlocked()
    {
        RequirementTextObject.GetComponentInChildren<Image>().sprite = UIManager.ui_manager.unlocked;// (Sprite)Resources.Load<Sprite>("Unlocked");
    }
    public void Locked()
    {
        RequirementTextObject.GetComponentInChildren<Image>().sprite = UIManager.ui_manager.locked;// (Sprite)Resources.Load<Sprite>("Locked");
    }
}
