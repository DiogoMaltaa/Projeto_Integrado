using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMenu : MonoBehaviour
{
    public Vector3 speed;

    void Update()
    {
        gameObject.transform.position += speed;
    }
}
