using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destrucatable : MonoBehaviour
{

    public GameObject destructableObject;

    public void DestroyObject()
    {
        Instantiate(destructableObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
