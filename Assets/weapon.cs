using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] private AudioSource fire;
    [SerializeField] private AudioSource fire2;
    private SpriteRenderer sp;
    public Transform fireright;
    public Transform fireleft;
    public GameObject firerightprefab;
    public GameObject fireleftprefab;
    Vector2 firepos;
    
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetButtonDown("Fire1"))
        {
            firepos = fireright.position;

            if(sp.flipX ==false)
            {
               fire.Play();
                firepos = fireright.position;
                Instantiate(firerightprefab ,firepos ,Quaternion.identity);
            }
            else
            {
                fire2.Play();
                firepos = fireleft.position;
                Instantiate(fireleftprefab ,firepos ,Quaternion.identity);
            }


              
            
            
        }
        
    }

    



    
}
