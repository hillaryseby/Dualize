using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    private int health = 100;
    [SerializeField] private AudioSource death;
    [SerializeField] private AudioSource hit;
   
    private Animator anim;



    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("bullet"))
        {
            hit.Play();
            health -= 25;

            if(health <=0)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        death.Play();
        anim.SetTrigger("death");
        Invoke("vanish", 0.4f);
        
    }

    private void vanish()
    {
        Destroy(gameObject);
    }
    
}
