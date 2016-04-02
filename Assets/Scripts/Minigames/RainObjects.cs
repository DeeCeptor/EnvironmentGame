using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RainObjects : MonoBehaviour
{
    public List<GameObject> objects_to_spawn = new List<GameObject>();
    public int number_of_initial_objects;
    public float spawn_rate = 0.3f;
    public float min_speed = 0.1f;
    public float max_speed = 0.4f;

    float cur_spawn_rate;
    BoxCollider2D zone;

    void Start()
    {
        zone = this.GetComponent<BoxCollider2D>();

        // Spawn initial objects
        for (int x = 0; x < number_of_initial_objects; x++)
        {
            SpawnObject();
        }
	}


    void Update ()
    {
        cur_spawn_rate -= Time.deltaTime;

        if (cur_spawn_rate <= 0)
            SpawnObject();
	}


    public void SpawnObject()
    {
        cur_spawn_rate = spawn_rate;

        // Randomly choose an object to spawn
        GameObject obj = objects_to_spawn[Random.Range(0, objects_to_spawn.Count - 1)];

        // Position it randomly with an area
        Vector2 pos = new Vector2(Random.Range(this.transform.position.x - (zone.bounds.size.x / 2f), (this.transform.position.x + (zone.bounds.size.x / 2f)))
                                , Random.Range(this.transform.position.y - (zone.bounds.size.y / 2f), (this.transform.position.y + (zone.bounds.size.y / 2f))));

        GameObject new_obj = (GameObject) Instantiate(obj, pos, Quaternion.identity);
        new_obj.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360f));


        // Set its speed randomly betweenmin and max speeds
        new_obj.GetComponent<Rigidbody2D>().gravityScale = (float) Random.Range(min_speed, max_speed);


    }
}
