using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfollower : MonoBehaviour
{
    private float speed = 5;
    public Transform player;
    private Animator anim;
    private SpriteRenderer rhino;
    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        anim =GetComponent<Animator>();
        rhino = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        float dirx = Input.GetAxisRaw("Horizontal");
        if(dirx<0)
        {
            rhino.flipX = true;


        }

        
        if (Vector2.Distance(transform.position, player.position) < 7f  && Vector2.Distance(transform.position, player.position) >0.5f)
        {
            
           

                anim.SetBool("move", true);
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            
        }

           
        else
        {
            anim.SetBool("move", false);
        }
    }

    

}