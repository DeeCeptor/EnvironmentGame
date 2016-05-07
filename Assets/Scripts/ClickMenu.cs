using UnityEngine;
using System.Collections;

public class ClickMenu : MonoBehaviour 
{
    public GameObject conv;
    bool loading = false;

	void Start () 
	{
	
	}
	

	void Update () 
	{
	    if (Input.GetMouseButton(0) && !loading)
        {
            loading = true;
            SceneManager.scene_manager.Start_Conversation(conv);
        }
	}
}
