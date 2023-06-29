using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfProto : MonoBehaviour
{
    public float timeToEnd;

    public void Update()
    {
        timeToEnd -= Time.deltaTime;

        if(timeToEnd <= 0)
        {
            Application.Quit();
        }
    }
}
