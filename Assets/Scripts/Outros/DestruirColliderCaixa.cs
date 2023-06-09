using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirColliderCaixa : MonoBehaviour
{
    public GameObject colliderToDestroy;
    public float timerToDestroy;
    float time;

    // Update is called once per frame
    void Update()
    {
        if(time >= timerToDestroy)
        {
            Destroy(colliderToDestroy);
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
