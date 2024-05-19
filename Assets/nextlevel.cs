using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
   
    private bool ischecked = false;
    [SerializeField] private AudioSource aud;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name =="mainplayer")
        {
            aud.Play();
            ischecked = true;
            Invoke("next", 3f);
        }
    }

    private void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }


}
