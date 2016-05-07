using UnityEngine;
using System.Collections;

public class ShrinkObject : MonoBehaviour 
{

	void Start () 
	{
	
	}
	

	void Update () 
	{
        this.transform.localScale *= 0.99f;

        if (this.transform.localScale.x <= 0.01f)
            Destroy(this.gameObject);
	}
}
