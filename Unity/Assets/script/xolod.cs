using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xolod : MonoBehaviour
{
    public Animator anim;
    public Transform holodPos;
    public bool isOpen = false;
    public GameObject egg;

    void Start()
    {
        egg.SetActive(false);
        anim = GetComponent<Animator>();
    }

    
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))

            if (collision.GetComponent<personag>().timer <= 0 && Input.GetKeyDown(KeyCode.E) && !isOpen)
            {
                anim.SetBool("open", true);
                isOpen = true;
                egg.SetActive(true);

                collision.GetComponent<personag>().timer = 1;
            }
        if (collision.GetComponent<personag>().timer <= 0 && Input.GetKeyDown(KeyCode.E) && isOpen)
        {
            collision.GetComponent<personag>().egg = true;
            egg.SetActive(false);
            collision.GetComponent<personag>().eggIm.SetActive(true);
        }
    }
}