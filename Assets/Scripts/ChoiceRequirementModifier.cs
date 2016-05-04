using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChoiceRequirementModifier : MonoBehaviour 
{
    public int button_number; // 1,2,3,4
    public Button our_button;
    public GameObject RequirementTextObject;
    [HideInInspector]
    public bool used_before = false;

    void Start () 
	{
	
	}


    // Pass in the button to modify. Override this method with your own logic.
    public virtual void ModifyButton(Button button)
    {
        our_button = button;

        our_button.onClick.RemoveAllListeners();
        our_button.onClick.AddListener(delegate { HideRequirements(); });
        RequirementTextObject = our_button.transform.FindChild("RequirementText").gameObject;

        if (used_before)
        {
            RequirementTextObject.SetActive(true);
        }
    }

    public void HideRequirements()
    {
        RequirementTextObject.SetActive(false);
        used_before = true;
    }
}
