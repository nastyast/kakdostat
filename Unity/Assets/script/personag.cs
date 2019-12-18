using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personag : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public GameObject p1, p2, p3;

    public float timer = 1f;

    //[HideInInspector]
    public bool spihki = false;
    public bool marker = false;
    public bool egg = false;

    public GameObject eggIm;
    public GameObject markerIm;
    public GameObject spihkiIm;
    // Start is called before the first frame update
    void Start()
    {
        eggIm.SetActive(false);
        markerIm.SetActive(false);
        spihkiIm.SetActive(false);
        p1.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }

        Vector2 moveV = new Vector2(Input.GetAxis("Horizontal") * 40, rigidbody2D.velocity.y);
        rigidbody2D.velocity = moveV;

        if(Input.GetAxis("Horizontal") < 0)
        {
            p2.SetActive(true);
            p1.SetActive(false);
            p3.SetActive(false);
        } else if (Input.GetAxis("Horizontal") > 0)
        {
            p3.SetActive(true);
            p1.SetActive(false);
            p2.SetActive(false);
        } else
        {
            p1.SetActive(true);
            p2.SetActive(false);
            p3.SetActive(false);
        }
    }
}
