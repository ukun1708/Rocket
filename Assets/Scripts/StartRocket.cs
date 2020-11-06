using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRocket : MonoBehaviour
{
    Rigidbody rb;

    public float force = 5f;

    public bool isPressed = false;

    public static StartRocket Singletone;

    private void Awake()
    {
        Singletone = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rb.useGravity = false;
            rb.AddRelativeForce(Vector3.up * force * Time.deltaTime, ForceMode.Impulse);
            isPressed = true;

        }
        else
        {
            rb.useGravity = true;
            isPressed = false;
        }

    }
}
