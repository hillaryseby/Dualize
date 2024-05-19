using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemscript : MonoBehaviour
{
    [SerializeField] private Text txt;
    [SerializeField] AudioSource collect;
    [SerializeField] private AudioSource col;
    private int count = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("item"))
        {
            collect.Play();
            Destroy(collision.gameObject);
            count++;
            txt.text = "points :" + count;
            
        }

        if(collision.gameObject.CompareTag("fall"))
        {
            
            count = count+30;
            txt.text = "points :" + count;
        }

        if(collision.gameObject.CompareTag("fall2"))
        {
            col.Play();
            count = count + 30;
            txt.text = "points :" + count;
            Destroy(collision.gameObject);

        }
    }


}
