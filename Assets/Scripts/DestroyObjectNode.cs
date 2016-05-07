using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Not used in real code. Merely a template to copy and paste from when creating new nodes.
public class DestroyObjectNode : Node
{
    public GameObject obj_to_destroy;

    public override void Run_Node()
    {
        Destroy(obj_to_destroy);
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
