using UnityEngine;
using System.Collections;

public class DestroyAfterNoise : MonoBehaviour
{
    AudioSource source;

    void Start ()
    {
        source = this.GetComponent<AudioSource>();
    }


    void Update ()
    {
        if (!source.isPlaying)
            Destroy(this.gameObject);
	}
}
