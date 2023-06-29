using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVida : MonoBehaviour
{
    public int vida;


    Level1Manager level1;

    private void Start()
    {
        level1 = FindObjectOfType<Level1Manager>();
    }

    private void Update()
    {
        DestruirNave();
    }

    void DestruirNave()
    {
        if(vida <= 0)
        {
            Destroy(gameObject);
            level1.enemiesKilled += 1;
        }
    }

    public void TomarDano(int damage)
    {
        Debug.Log("Ai!");
        vida -= damage;
    }
}
