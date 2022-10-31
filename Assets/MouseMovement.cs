using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class MouseMovement : MonoBehaviour
{
   
    private Rigidbody2D rb;
    public float rotateSpeed = 1500f;
    public float speed = 7f;
    private Vector3 mousePosition;
    public int score ;
    public float pointIncrease;
    float time = 0;
    public float showscore;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        
    }
    void FixedUpdate()
    {
        showscore = (time * pointIncrease);
        score = (int)showscore + 10 * count;
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 dir = (Vector2)mousePosition - rb.position;

        dir.Normalize();

        float rotateAmount = Vector3.Cross(dir, transform.up).z;

        rb.angularVelocity = -(rotateAmount * rotateSpeed);

        rb.velocity = transform.up * speed;
    }
}
