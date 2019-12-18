using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Animator anim;
    public Transform doorPos;

    void Start()
    {

        anim = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))

            if (collision.GetComponent<personag>().timer <= 0 && Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("open", true);
                collision.gameObject.transform.position = doorPos.position;
                collision.GetComponent<personag>().timer = 1;
            }
    }
}
