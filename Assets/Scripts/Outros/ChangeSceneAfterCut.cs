using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ChangeSceneAfterCut : MonoBehaviour
{
    [SerializeField] string nextSceneName;
    public double time;
    public double currentTime;
   
    void Start()
    {

        time = gameObject.GetComponent<VideoPlayer>().clip.length -0.5f;
    }


    
    void Update()
    {
        currentTime = gameObject.GetComponent<VideoPlayer>().time;
        if (currentTime >= time)
        {
            Debug.Log("//do Stuff");
        }

        if (currentTime == time)
        {
            SceneManager.LoadScene(nextSceneName);
        }

    }




}
