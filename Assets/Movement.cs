using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update



    // Update is called once per frame

    public FixedJoystick joystick;
    public Rigidbody2D rb;
    public Vector2 move;
    public float moveSpeed;
    public FloatingJoystick j;
    public Vector2 movenote;
    public Vector2 nextpos;
    public float rotatespeed;
    public float rotateamount;

    public static bool PointerDown = false;

    private void Start()
    {
        movenote.x = 0f;
        movenote.y = -1f;
    }


    private void Update()
    {
        


        //float hAxis = movenote.x;
        //float vAxis = movenote.y;
        //float zAxis = Mathf.Atan2(hAxis, vAxis) * Mathf.Rad2Deg;
        //transform.eulerAngles = new Vector3(0f, 0f, -zAxis);

        move.x = joystick.Horizontal;
        move.y = joystick.Vertical;
        if (move.magnitude != 0)
        {
            movenote.x = move.x;
            movenote.y = move.y;
        }
        


    }

    private void FixedUpdate()
    {
        move.x = 0f;
        move.y = 0f;

        if (PointerDown)
        {
            //  rb.position = Vector3.zero;
        }
        else
        {
            rotateamount = Vector3.Cross(movenote.normalized, transform.up).z;
            if (move.magnitude != 0)
            {
                rb.angularVelocity = -(rotateamount * rotatespeed);
            }
     
            rb.velocity = (transform.up * moveSpeed);
            
        }


    }
}

