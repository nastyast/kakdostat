using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_prav : MonoBehaviour
{
    
    public Transform doorPos;

    void Start()
    {

        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))

            if (collision.GetComponent<personag>().timer <= 0 && Input.GetKeyDown(KeyCode.Space))
            {
               
                collision.gameObject.transform.position = doorPos.position;
                collision.GetComponent<personag>().timer = 1;
            }
    }
}
