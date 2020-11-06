using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelHealth : MonoBehaviour
{
    public float lvlHealth = 100;

    public Slider mySlyder;

    void Update()
    {
        mySlyder.value = lvlHealth;
    }
}
