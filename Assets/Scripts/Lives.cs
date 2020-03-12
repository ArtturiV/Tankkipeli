using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    [SerializeField]
    float lives = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (lives < 1)
        {
            Destroy(gameObject);
        }
    }

    public void Hit()
    {
        lives--;
    }
}
