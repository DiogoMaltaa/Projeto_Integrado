using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
        InFront();
    }

    bool InFront()
    {
        Vector3 directionalToTarget = transform.position - target.position;
        float angle = Vector3.Angle(transform.forward, directionalToTarget);

        //if in range
        if (Mathf.Abs(angle) > 90 && Mathf.Abs(angle) < 270)
        {
            Debug.DrawLine(transform.position, target.position, Color.green);
            return true;
        }
        
        Debug.DrawLine(transform.position, target.position, Color.yellow);
        return false;
    }





}
