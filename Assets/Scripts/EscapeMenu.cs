using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour 
{
    public string scene_to_load;

	void Start () 
	{
	
	}
	

	void Update () 
	{
        if (Input.GetKeyDown(KeyCode.Escape))
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene_to_load);
    }
}
