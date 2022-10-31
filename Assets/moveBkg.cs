using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBkg : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.x-transform.position.x>10)
        {
            transform.position += new Vector3(22.4f,0,0);
        }
        if(player.position.x-transform.position.x<-10)
        {
            transform.position += new Vector3(-22.4f,0,0);
        }
        if(player.position.y-transform.position.y<-5)
        {
            transform.position += new Vector3(0,-11.2f,0);
        }
        if(player.position.y-transform.position.y>5)
        {
            transform.position += new Vector3(0,11.2f,0);
        }
    }
}
