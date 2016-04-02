using UnityEngine;
using System.Collections;

public class Bin : MonoBehaviour
{
    public string bin_type;

    void Start ()
    {
	
	}


    void Update ()
    {
	
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer(bin_type))
        {
            Score.score.UpdateScore(1);
        }
        else
        {
            Score.score.UpdateScore(-1);
        }

        Destroy(other.gameObject);
    }
}
