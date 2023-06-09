using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercadoria : MonoBehaviour
{
    GameManager manager;
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    public void ApanharDroga()
    {
        manager.Mercadoria(1);
        Destroy(gameObject);
    }
}
