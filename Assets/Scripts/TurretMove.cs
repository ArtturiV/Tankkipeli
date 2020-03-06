using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D torni = null;
    GameObject runko;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        torni = GetComponent<Rigidbody2D>();
        runko = GameObject.Find("PHhull");
        rb = runko.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        torni.velocity = rb.velocity;

    }
}
