using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoDestruirObjetos : MonoBehaviour
{
    public Animation anim;


    private void Start()
    {
        anim.Stop();
    }

    public void PlayDestroyAnimation()
    {
        anim.Play();
    }
    

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
