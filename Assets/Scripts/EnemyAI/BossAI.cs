using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossAI : MonoBehaviour
{
    [Header("Health")]
    public int bossHealth;
    public Slider healthBar;

    [Header("AttackStates")]
    public float timeBetweenAttacks;
    public float attackToChoose;
    public bool chooseAttack;
    public bool canAttack;

    public Animator anim;

    [Header("Random Spawn")]
    int index;
    public Transform[] spawns;
    public Transform currentSpawn;
    bool hasChoosenSpawn;


    private void Start()
    {
        timeBetweenAttacks = 0;
        attackToChoose = 0;
        chooseAttack = false;
        anim.enabled = false;
        canAttack = false;
        hasChoosenSpawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = bossHealth;

       if(canAttack == false)
        {
            timeBetweenAttacks = Random.Range(0, 120);
        }

       if (timeBetweenAttacks == 40)
        {
            canAttack = true;
        }
        else
        {
            canAttack = false;
        }

        if (!chooseAttack)
        {
            attackToChoose = Random.Range(0, 60);
        }

        if(attackToChoose == 1 || attackToChoose == 2)
        {
            chooseAttack = true;
        }
        if (attackToChoose == 0)
        {
            chooseAttack = false;
        }

        if(canAttack == true)
        {

            if(attackToChoose == 1)
            {
                anim.enabled = true;
                anim.SetBool("isAttack1", false);
                anim.SetBool("isAttack2", true);
            }
            if(attackToChoose == 2)
            {
                anim.enabled = true;
                anim.SetBool("isAttack1", true);
                anim.SetBool("isAttack2", false);
            }
        
        }

        Health();

        if(hasChoosenSpawn == false)
        {
            index = Random.Range(0, spawns.Length);
            currentSpawn = spawns[index];
            hasChoosenSpawn = true;
        }
    }


    public void EndAttack()
    {
        timeBetweenAttacks = 0;
        attackToChoose = 0;
        anim.enabled = false;
        chooseAttack = false;

        Debug.Log("Im STUPID");

        gameObject.transform.position = currentSpawn.position;
        hasChoosenSpawn = false;
    }

    public void Health()
    {
        if(bossHealth <= 0)
        {
            anim.SetBool("isDead", true); //Do Death

            anim.SetBool("isAttack1", false); //Stop Other Anim
            anim.SetBool("isAttack2", false); //Stop Other Anim
        }
    }

    public void KillBoss()
    {
        Destroy(gameObject);
    }
}
