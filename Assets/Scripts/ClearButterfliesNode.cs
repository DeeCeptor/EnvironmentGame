using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Not used in real code. Merely a template to copy and paste from when creating new nodes.
public class ClearButterfliesNode : Node
{
    public override void Run_Node()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Butterfly"))
        {
            Destroy(obj);
        }
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
