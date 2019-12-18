﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gadosti : MonoBehaviour
{
    public GameObject level;
    public int gad = 0;
    Text myText;
    string dalhe = "/3";
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
    }
    
    // Update is called once per frame
    void Update()
    {
        myText.text = gad + dalhe;
        if (gad == 3)
        {
            level.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
