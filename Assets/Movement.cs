using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

  PlayerControls playerControls;

    // Update is called once per frame

   
    public Rigidbody2D rb;
    public Vector2 move;
    public float moveSpeed;
   
    public Vector2 movenote;
    public Vector2 nextpos;
    public float rotatespeed;
    public float rotateamount;

    public static bool PointerDown = false;

    private void Start()
    {
        movenote.x = 0f;
        movenote.y = 1f;
       
    }


   /* private void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        playerControls.Gameplay.Move.canceled += ctx => move = Vector2.zero; 
    }*/

    private void Update()
    {
        Gamepad gamepad = Gamepad.current;
        if (gamepad != null)
        {
            move = gamepad.leftStick.ReadValue();
           
        }

    }

    private void FixedUpdate()
    {
        

            rotateamount = Vector3.Cross(move.normalized, transform.up).z;
            if (move.magnitude != 0)
            {
                rb.angularVelocity = -(rotateamount * rotatespeed);
            }
            else
            {
                rb.angularVelocity = 0f;
            }
     
            rb.velocity = (transform.up * moveSpeed);
            
        


    }
}

