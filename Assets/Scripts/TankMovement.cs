using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    float velo = 0;
    float radsin;
    float radcos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        radsin = Mathf.Sin(Mathf.PI * (transform.rotation.eulerAngles.z / 180));

        radcos = Mathf.Cos(Mathf.PI * (transform.rotation.eulerAngles.z / 180));
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector2(radsin * -velo, radcos * velo);

        }
        if (Input.GetKeyUp("w"))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(radsin * velo, radcos * -velo);

        }
        if (Input.GetKeyUp("s"))
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        if (Input.GetKeyDown("r"))
        {
            
            print("Sin " + radsin);
            print("Cos " + radcos);

        }

    }
}
