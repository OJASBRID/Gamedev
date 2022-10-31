using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmovement1 : MonoBehaviour
{


    public Transform target;
    public float t;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        // returns a random number between 0 and 10

        float randomy = Random.Range(-5.5f, 5.5f);
        Vector3 a = transform.position;
        Vector3 adddist = new Vector3(10.3f, randomy, 0f);
        Vector3 b = target.position + adddist;
        transform.position = Vector3.MoveTowards(a, b, speed);
    }
}
