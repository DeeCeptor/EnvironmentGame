using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectBio : MonoBehaviour
{
    public string character_name;
    public string age;
    public Sprite profile_image;

    [TextArea(8, 10)]
    public string character_bio;

    public Text text_field_name;
    public Text text_field_bio;
    public Text text_field_age;
    public Image text_image;

    void Start ()
    {
	
	}

    public void SetBio()
    {
        Canvas.ForceUpdateCanvases();
        text_field_name.text = character_name;
        text_field_bio.text = character_bio;
        //text_field_age.text = "Age: " + age;
        text_field_age.text = NimosStats.stats.RelationshipWith(character_name);

        text_image.sprite = profile_image;
        text_image.color = new Color(text_image.color.r, text_image.color.g, text_image.color.b, 255f);



        //text_field_bio.transform.parent.parent.GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
        //text_field_bio.transform.parent.parent.GetComponent<ScrollRect>().verticalScrollbar.value = 1;
        text_field_bio.transform.parent.parent.GetComponent<ScrollRect>().velocity = new Vector2(0f, -1000f);
        Canvas.ForceUpdateCanvases();
    }
}
