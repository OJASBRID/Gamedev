using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmovement : MonoBehaviour
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
        
        float randomx = Random.Range(-9f, 9f);
        Vector3 a = transform.position;
        Vector3 adddist = new Vector3(randomx,-5.70f ,0f);
        Vector3 b = target.position + adddist;
        transform.position = Vector3.MoveTowards(a, b, speed);
    }
}
