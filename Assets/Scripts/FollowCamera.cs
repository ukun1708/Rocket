using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;

    public float smooth = 5f;

    public Vector3 offset = new Vector3(0, 2, -5);

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth);

        if (StartRocket.Singletone.isPressed == true)
        {
            transform.position += Random.insideUnitSphere * 0.03f;
        }
        else
        {
                
        }

    }


}
