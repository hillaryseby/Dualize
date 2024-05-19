using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracomponent : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -10);
        
    }
}
