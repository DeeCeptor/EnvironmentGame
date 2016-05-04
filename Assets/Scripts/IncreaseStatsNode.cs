using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IncreaseStatsNode : Node
{
    public string source;

    public int increase_Intelligence;
    public int increase_Resolve;
    public int increase_Charm;
    public float increase_Money;
    public string item_or_idea;

    public string message_to_show;

    public int JB_relationship;
    public int Pinkerton_relationship;
    public int Soilsmith_relationship;

    public override void Run_Node()
    {
        NimosStats.stats.AddStats(source, message_to_show, item_or_idea, increase_Intelligence, increase_Charm, increase_Resolve, 
            increase_Money, JB_relationship, Pinkerton_relationship, Soilsmith_relationship);
        Finish_Node();
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
