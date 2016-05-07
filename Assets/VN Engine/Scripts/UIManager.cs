using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public static UIManager ui_manager;

    public Canvas canvas;

	public Text dialogue_text_panel;
	public Text speaker_text_panel;
	public GameObject choice_panel;
	public Image background;	// Background image
	public Image foreground;    // Image appears in front of ALL ui elements
    public Text log_text;   // Log containing all dialogue spoken
    public GameObject entire_UI_panel;

    // Used by choice dialogue node
    public Button choice_1_button;
    public Button choice_2_button;
    public Button choice_3_button;
    public Button choice_4_button;

    public Sprite locked;
    public Sprite unlocked;

    public GameObject actor_positions;

    public Text Intellect;
    public Text Resolve;
    public Text Charm;
    public Text Money;

    public GameObject Ideas;
    public Button Select_Ideas_Button;
    public SelectIdeaNode current_idea_node;
    public string selected_idea = "";

    void Awake ()
    {
		ui_manager = this;
	}


    public void SelectIdea()
    {
        if (selected_idea != "")
            current_idea_node.IdeaSelected(selected_idea);
    }


    void Update ()
    {
	
	}
}
