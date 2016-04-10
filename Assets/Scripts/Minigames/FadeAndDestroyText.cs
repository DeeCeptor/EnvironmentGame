using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeAndDestroyText : MonoBehaviour
{
    public float fade_delay = 1.0f; // How long to wait before we start fading
    public float duration = 1.0f;
    Text text;

	void Start ()
    {
        text = this.GetComponent<Text>();
	}


    void Update ()
    {
        fade_delay -= Time.deltaTime;

        if (fade_delay <= 0)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - Time.deltaTime * (duration / 1f));

            if (text.color.a <= 0f)
            {
                Destroy(this.gameObject);
            }
        }
	}
}
