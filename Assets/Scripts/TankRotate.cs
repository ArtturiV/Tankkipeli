using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRotate : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    float degrees = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("j"))
        {
            rb.transform.Rotate(0, 0, degrees * Time.deltaTime);
        }
        if (Input.GetKey("l"))
        {
            rb.transform.Rotate(0, 0, -degrees * Time.deltaTime);
        }

    }
}
