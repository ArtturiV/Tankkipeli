using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRotate : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb = null;
    [SerializeField]
    float degrees = 0;
    [SerializeField]
    string n1 = null;
    [SerializeField]
    string n2 = null;
    public float kulma = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(n1))
        {
            rb.transform.Rotate(0, 0, degrees * Time.deltaTime);
            
        }
        if (Input.GetKey(n2))
        {
            rb.transform.Rotate(0, 0, -degrees * Time.deltaTime);
        }

        if (Input.GetKey(n1))
        {
            kulma = degrees;
        }
        else if(Input.GetKey(n2))
        {
            kulma = -degrees;
        }
        else
        {
            kulma = 0;
        }

    }
}
