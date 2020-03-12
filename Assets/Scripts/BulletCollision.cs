using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    float bounces = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            bounces++;
            Lives h;
            h = collision.collider.GetComponent<Lives>();
            h.Hit();
        }
        else
        {
            rb.velocity = Vector2.Reflect(this.transform.position, collision.GetContact(0).normal);
            print("Törm");
            bounces++;
            if (bounces > 2)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
