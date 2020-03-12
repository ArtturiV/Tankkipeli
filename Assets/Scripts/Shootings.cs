using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootings : MonoBehaviour
{
    [SerializeField]
    GameObject ammo;
    float radsin;
    float radcos;
    float xpos;
    float ypos;
    [SerializeField]
    string shoot = null;
    [SerializeField]
    string tagg = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        radsin = Mathf.Sin(Mathf.PI * (transform.rotation.eulerAngles.z / 180));
        radcos = Mathf.Cos(Mathf.PI * (transform.rotation.eulerAngles.z / 180));
        xpos = transform.position.x - (0.721f * radsin);
        ypos = transform.position.y + (0.721f * radcos);

        if (2 > GameObject.FindGameObjectsWithTag(tagg).Length)
        {
            if (Input.GetKeyDown(shoot))
            {
                Instantiate(ammo, new Vector3(xpos, ypos, -1f), transform.rotation);
            }
        }
        
        
    }
}
