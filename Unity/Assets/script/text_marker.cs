using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_marker : MonoBehaviour
{
    public GameObject textmarker;
    public string TextTriger;

    void Start()
    {
        textmarker.SetActive(false);
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            if (collision.GetComponent<personag>().timer <= 0)
        {
                textmarker.SetActive(true); 
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        textmarker.SetActive(false);
    }
    void Update()
    {
        
    }
}
