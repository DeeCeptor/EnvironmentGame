using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetText : MonoBehaviour
{
    public Text description;
    [TextArea(8, 10)]
    public string item_description;


    void Start()
    {

    }



    public void SetTextField()
    {
        Canvas.ForceUpdateCanvases();
        description.text = item_description;
        Canvas.ForceUpdateCanvases();
    }
}
