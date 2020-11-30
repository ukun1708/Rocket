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

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            RotRight();
        }
    }

    void RotLeft()
    {
        transform.rotation *= Quaternion.Euler(Vector3.forward * speed * Time.deltaTime);
    }

    void RotRight()
    {
        transform.rotation *= Quaternion.Euler(Vector3.back * speed * Time.deltaTime);
    }
}
