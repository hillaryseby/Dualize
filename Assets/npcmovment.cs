using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcmovment : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints;
    private Rigidbody2D bird;
    private SpriteRenderer sp;

    [SerializeField] private float speed;
    private int currentwaypointindex = 0;

    private void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(waypoints[currentwaypointindex].transform.position, transform.position) < .1f)
        {
            sp.flipX = true;
            currentwaypointindex++;

            if (currentwaypointindex >= waypoints.Length)
            {
                sp.flipX=false;
                currentwaypointindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentwaypointindex].transform.position, Time.deltaTime * speed);

    }
}
