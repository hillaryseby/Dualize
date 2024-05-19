using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class darkworld : MonoBehaviour
{

    public AudioSource dark;

    private bool ischecked = false;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name =="mainplayer")
        {
            dark.Play();
            ischecked = true;
            Invoke("nextlevel",0.5f);

        }
    }

    private void nextlevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }


}
