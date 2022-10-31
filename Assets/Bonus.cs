using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public int count;
    Movement ms;
    // Start is called before the first frame update
    void Start()
    {
        ms = GameObject.Find("Plane").GetComponent<Movement>();
        
    }

    void OnTriggerEnter2D(){
        ms.count++;
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
