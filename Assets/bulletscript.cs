using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    private Rigidbody2D bullet;
    [SerializeField] private float velX = 5f;
    [SerializeField] private float veY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bullet.velocity = new Vector2(velX ,veY);
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
    }
}
