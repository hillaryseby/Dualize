using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followerscript : MonoBehaviour
{

    public float speed = 12f;
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,360 *Time.deltaTime);

        
        
    }
}
