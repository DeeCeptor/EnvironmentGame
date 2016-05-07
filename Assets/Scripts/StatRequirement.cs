using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatRequirement : IfElseThenModifier
{
    public int minimum_int = 0;
    public int minimum_resolve = 0;
    public int minimum_charm = 0;
    public float minimum_money = -1;
    public string idea_item = "";
    public string requirement_message;

    public int minimum_JB_relationship = -5;
    public int minimum_Soilsmith_relationship = -5;
    public int minimum_Pinkerton_relationship = -5;

    public override void ModifyButton(Button button)
    {
        base.ModifyButton(button);

        if (requirement_message == "")
            RequirementTextObject.SetActive(false);
        else if (used_before)
        {
            RequirementTextObject.SetActive(true);
            RequirementTextObject.GetComponent<Text>().text = requirement_message;
        }

        if (NimosStats.stats.Intellect > minimum_int
            && NimosStats.stats.Resolve > minimum_resolve
            && NimosStats.stats.Charm > minimum_charm
            && NimosStats.stats.Money > minimum_money
            && (idea_item == "" || NimosStats.stats.HasItemIdea(idea_item))
            && NimosStats.stats.Jamminben_Relationship > minimum_JB_relationship
            && NimosStats.stats.Soilsmith_Relationship > minimum_Soilsmith_relationship
            && NimosStats.stats.Pinkerton_Relationship > minimum_Pinkerton_relationship
            )
        {
            Unlocked();
            button.onClick.AddListener(() => SceneManager.scene_manager.Start_Conversation_If_Not_Null(conversation_to_start_if_unlocked, main_conversation_is_null) );
        }
        else
        {
            Locked();
            button.onClick.AddListener(delegate { SceneManager.scene_manager.Start_Conversation(conversation_if_locked.gameObject); button.onClick.RemoveAllListeners(); button.gameObject.SetActive(false); button.gameObject.SetActive(true); } );
        }
        //our_button.onClick.AddListener(delegate { HideRequirements(); });
    }
}
