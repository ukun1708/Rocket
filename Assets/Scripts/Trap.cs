using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1.5f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (transform.position.x > 13f)
        {
            speed = -speed;
        }

        if (transform.position.x < 7f)
        {
            speed = Random.Range(1.5f, 3f);
        }
    }
}
