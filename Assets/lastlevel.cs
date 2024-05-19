using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lastlevel : MonoBehaviour
{
    private bool ischecked = false;
    [SerializeField] private AudioSource finish;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name =="mainplayer" && !ischecked)
        {
            finish.Play();
            Invoke("last" ,3f);
        }
    }

    private void last()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
