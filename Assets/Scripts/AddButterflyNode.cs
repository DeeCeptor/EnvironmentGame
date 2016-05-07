using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Not used in real code. Merely a template to copy and paste from when creating new nodes.
public class AddButterflyNode : Node
{
    public bool left_to_right;

    public override void Run_Node()
    {
        //StartCoroutine();
        GameObject obj = (GameObject)GameObject.Instantiate(Resources.Load<GameObject>("Butterfly"));//, new Vector3(0, 0, 0), Quaternion.identity);
        obj.GetComponent<Wander>().left_to_right = left_to_right;

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
