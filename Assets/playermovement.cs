using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private AudioSource jump;
    [SerializeField] private float jumpforce = 12f;
    [SerializeField] float movespeed = 6f;
    private SpriteRenderer body;
    private Rigidbody2D player;
    private Animator anim;
    private BoxCollider2D box;
    [SerializeField] private LayerMask jumpable;
    [SerializeField] private float tramjump;
   
    private enum animstate
    { idle,
        running,
         jump,
         fall
       
    }
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        body = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isgrounded())
        {
            jump.Play();
            player.velocity = new Vector2(player.velocity.x , jumpforce);
            
        }
        float dirx = Input.GetAxisRaw("Horizontal");
        



       
        

        player.velocity = new Vector2(dirx *movespeed , player.velocity.y);

        setanim(dirx,body);

        if(Input.GetKey(KeyCode.C))
        {
            anim.SetBool("duck", true);
        }
        else
        {
            anim.SetBool("duck", false);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trampoline"))
        {
            player.velocity = new Vector2(player.velocity.x,tramjump);
        }
    }
       
    

    private void setanim(float dir ,SpriteRenderer body)
    {
        animstate state;

        if (dir > 0)
        {
            body.flipX = false;
            state = animstate.running;
        }
        else if (dir < 0 ) 
        {
            body.flipX = true;
            state = animstate.running;
        }
        else
        {
            state = animstate.idle;
        }

        if (player.velocity.y > .1f)
        {
            state = animstate.jump;
        }

        else if(player.velocity.y<-.1f)
        {
            state = animstate.fall;
        }

        anim.SetInteger("state",(int) state);
    }

    public bool isgrounded()
    {
        return Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, .1f, jumpable);
    }
}
