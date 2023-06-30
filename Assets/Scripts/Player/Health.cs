using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    int currentHealth;
    public int maxHealth;
    public Image healthBar;

    public string sceneName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = currentHealth / maxHealth;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boss")
        {
            currentHealth -= 6;
        }

        if(collision.tag == "Rock")
        {
            currentHealth -= 12;
        }
    }

    void CheckDeath()
    {
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
