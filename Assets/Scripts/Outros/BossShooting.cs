using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject rock;

    public void Shooting()
    {
        Instantiate(rock, shootingPoint.position, Quaternion.identity);
    }
}
