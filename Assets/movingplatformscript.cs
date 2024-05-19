using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatformscript : MonoBehaviour
{


    [SerializeField] private GameObject[] waypoints;

    [SerializeField] private float speed ;
    private int currentwaypointindex = 0;


    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(waypoints[currentwaypointindex].transform.position, transform.position) < .1f)
        {
            currentwaypointindex++;

            if (currentwaypointindex >= waypoints.Length)
            {
                currentwaypointindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentwaypointindex].transform.position, Time.deltaTime * speed);

    }
}
    
