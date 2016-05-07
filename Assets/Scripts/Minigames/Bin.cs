using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bin : MonoBehaviour
{
    public string bin_type;
    public GameObject sound_clip;
    public GameObject wrong_clip;
    public Text text;

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
            switch (bin_type)
            {
                case "Can":

                    break;
            }
            GameObject obj = (GameObject)Instantiate(sound_clip, transform.position, Quaternion.identity);

            obj = (GameObject)Instantiate(text.gameObject, transform.position, Quaternion.identity);
            obj.transform.SetParent(RainObjects.rain_objects.world_canvas);
            obj.transform.localScale = Vector3.one;
            // Set colours and text
            Color[] colors = { Color.green, Color.blue, Color.yellow };
            obj.GetComponent<Text>().color = colors[Random.Range(0, colors.Length)];
            string[] texts = { "Great!", "Nice", "Boo ya!" };
            obj.GetComponent<Text>().text = texts[Random.Range(0, texts.Length)];

            Score.score.UpdateScore(1);
        }
        else
        {
            GameObject obj = (GameObject)Instantiate(wrong_clip, transform.position, Quaternion.identity);

            obj = (GameObject)Instantiate(text.gameObject, transform.position, Quaternion.identity);
            obj.GetComponent<Text>().text = "Oops!";
            obj.transform.SetParent(RainObjects.rain_objects.world_canvas);
            obj.transform.localScale = Vector3.one;

            Score.score.UpdateScore(-1);
        }

        // Make it shrink
        other.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        other.gameObject.AddComponent<ShrinkObject>();
    }
}
