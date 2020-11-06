using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFire : MonoBehaviour
{
    Light lg;

    public float speedRot = 10f;

    public float intensityFire = 10f;

    public float RangeFire = 1f;

    // Start is called before the first frame update
    void Start()
    {
        lg = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartRocket.Singletone.isPressed == true)
        {
            lg.intensity += intensityFire * Time.deltaTime;
            //lg.range += RangeFire * Time.deltaTime;
        }

        else
        {
            lg.intensity -= intensityFire * 2f * Time.deltaTime;
            //lg.range -= RangeFire * Time.deltaTime;
        }
    }
}
