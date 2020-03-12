using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
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
        radsin = Mathf.Sin(Mathf.PI * (transform.rotation.eulerAngles.z / 180));
        radcos = Mathf.Cos(Mathf.PI * (transform.rotation.eulerAngles.z / 180));
        rb.velocity = new Vector2(radsin * -velo, radcos * velo);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
