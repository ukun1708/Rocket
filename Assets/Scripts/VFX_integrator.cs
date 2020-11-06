using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFX_integrator : MonoBehaviour
{
    public VisualEffect vfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartRocket.Singletone.isPressed)
        {
            vfx.SetFloat("LifeTime", 0.5f);
        }
        else
        {
            vfx.SetFloat("LifeTime", 0f);
        }

        vfx.SetVector3("Position", this.transform.position);

    }
}
