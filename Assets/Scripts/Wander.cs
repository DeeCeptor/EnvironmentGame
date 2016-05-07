using UnityEngine;
using System.Collections;

public class Wander : MonoBehaviour 
{
    Vector3 start_pos;
    float random_offset;
    float random_offset_2;
    SpriteRenderer sprit;
    float alpha = 0;
    public bool left_to_right = false;

    void Start () 
	{
        sprit = this.GetComponent<SpriteRenderer>();
        sprit.color = new Color(sprit.color.r, sprit.color.g, sprit.color.b, 0);
        start_pos = this.transform.position;
        random_offset = Random.Range(-1.2f, 1.2f);
        random_offset_2 = Random.Range(-1.2f, 1.2f);

        if (left_to_right)
            this.transform.position = new Vector3(-8, 0, 0);
    }


    void Update () 
	{
        if (!left_to_right)
            this.transform.position = new Vector3(start_pos.x + Mathf.Sin(Time.time * random_offset) * 1, start_pos.y + Mathf.Sin(Time.time * random_offset_2) * 1, 0);
        else
            this.transform.position += new Vector3(2.0f * Time.deltaTime, 0, 0);

        alpha += Time.deltaTime;
        sprit.color = new Color(sprit.color.r, sprit.color.g, sprit.color.b, alpha);
    }
}
