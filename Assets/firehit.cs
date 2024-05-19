using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firehit : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "mainplayer")
        {
            anim.SetTrigger("hit");
        }
    }
}
