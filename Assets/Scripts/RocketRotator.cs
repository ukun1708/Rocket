using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketRotator : MonoBehaviour
{ 
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation *= Quaternion.Euler(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation *= Quaternion.Euler(Vector3.back * speed * Time.deltaTime);
        }
    }
}
