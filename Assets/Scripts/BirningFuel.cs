using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirningFuel : MonoBehaviour
{
    public float birnFuel = 10;

    LevelHealth lvlH;

    StartRocket sR;

    Rigidbody rB;

    void Start()
    {
        lvlH = GetComponent<LevelHealth>();
        sR = GetComponent<StartRocket>();
        rB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartRocket.Singletone.isPressed == true)
        {
            lvlH.lvlHealth -= (birnFuel) * Time.deltaTime;
        }

        if (lvlH.lvlHealth <= 0f)
        {
            sR.enabled = false;

            rB.useGravity = true;

            StartRocket.Singletone.isPressed = false;
        }
    }
}
