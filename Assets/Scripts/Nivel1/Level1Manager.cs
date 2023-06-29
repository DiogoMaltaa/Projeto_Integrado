using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Manager : MonoBehaviour
{
    public int enemiesKilled;
    [SerializeField] string sceneToGo;

    void Start()
    {
        enemiesKilled = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemiesKilled >= 20)
        {
            SceneManager.LoadScene(sceneToGo);
        }
    }
}
