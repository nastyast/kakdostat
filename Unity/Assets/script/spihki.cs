﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spihki : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        if (Input.GetKeyDown(KeyCode.E))
        {
            collision.GetComponent<personag>().spihki = true;   
            collision.GetComponent<personag>().spihkiIm.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}