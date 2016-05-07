using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetText : MonoBehaviour
{
    public string title;

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
        UIManager.ui_manager.selected_idea = title;
        Canvas.ForceUpdateCanvases();
    }
}
