using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleDestroy : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 10f)
        {
            Destroy(gameObject);
            time = 0;
        }
    }

    // public void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (!collision.CompareTag("Respawn"))
    //     {
    //         Destroy(gameObject);    
    //     }
    // }
}
