using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotate : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    float degrees = 0;
    [SerializeField]
    string n1;
    [SerializeField]
    string n2;
    GameObject runko;
    TankRotate runkoRot;
    float apu;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        runko = GameObject.Find("PHhull");
        runkoRot = runko.GetComponent<TankRotate>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(n1))
        {
            apu = degrees;
        }
        if (Input.GetKey(n2))
        {
            apu = -degrees;
        }
        if (Input.GetKeyUp(n2))
        {
            apu = 0;
        }
        if (Input.GetKeyUp(n1))
        {
            apu = 0;
        }

        rb.transform.Rotate(0, 0, (apu + runkoRot.kulma) * Time.deltaTime);

    }
}
