using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TrailRenderer))]
[RequireComponent(typeof(Light))]

public class Thruster : MonoBehaviour
{
    TrailRenderer tr;
    Light thrLight;

    void Awake()
    {
        tr = GetComponent<TrailRenderer>();
        thrLight = GetComponent<Light>();
    }

    void Start()
    {
        thrLight.enabled = false;
        tr.enabled = false;
    }
    
    
    public void Activate(bool activate = true)
    {
        if(activate)
        {
            tr.enabled = true;
            thrLight.enabled = true;
            //liga partical effects
            //liga som
            //etc
        }
        else
        {
            tr.enabled = false;
            thrLight.enabled = false;
            //desliga tudo relacionado a thurst
        }
    }
}
