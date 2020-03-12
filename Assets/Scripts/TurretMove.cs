using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D torni = null;
    GameObject runko;
    Rigidbody2D rb;
    [SerializeField]
    string parent = null;
    // Start is called before the first frame update
    void Start()
    {
        torni = GetComponent<Rigidbody2D>();
        runko = GameObject.Find(parent);
        rb = runko.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        torni.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y, -1f);

    }
}
