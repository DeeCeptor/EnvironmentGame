using UnityEngine;
using System.Collections;

public class MoveObjectRandomly : MonoBehaviour
{
    public float x_min = -1.0f;
    public float x_max = 1.0f;
    public float y_min = -1.0f;
    public float y_max = 1.0f;
    public float speed = 1.0f;

    void Start ()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(x_min, x_max),
            Random.Range(y_min, y_max)).normalized * speed;
	}
}
