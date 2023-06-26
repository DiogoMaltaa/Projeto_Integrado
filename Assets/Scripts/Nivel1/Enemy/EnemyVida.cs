using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVida : MonoBehaviour
{
    public int vida;

    private void Update()
    {
        DestruirNave();
    }

    void DestruirNave()
    {
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TomarDano(int damage)
    {
        Debug.Log("Ai!");
        vida -= damage;
    }
}
