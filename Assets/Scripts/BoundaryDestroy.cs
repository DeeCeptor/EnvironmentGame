using UnityEngine;
using System.Collections;

public class BoundaryDestroy : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer != LayerMask.NameToLayer("Boundary"))
            Destroy(coll.gameObject);
    }
}
