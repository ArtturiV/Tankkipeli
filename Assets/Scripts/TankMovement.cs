using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    float velo = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector2(rb.velocity.x, velo);
            
        }
        if (Input.GetKeyUp("w"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(rb.velocity.x, -velo);

        }
        if (Input.GetKeyUp("s"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }

        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-velo, rb.velocity.y);

        }
        if (Input.GetKeyUp("a"))
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(velo, rb.velocity.y);

        }
        if (Input.GetKeyUp("d"))
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }
        
        rb.MoveRotation(rb.velocity.magnitude * 360);
    }
}
