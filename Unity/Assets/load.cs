using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    public Slider slider;
   private float timer;
public int Level;
private int slidV;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       slider.value = slidV;
timer +=Time.deltaTime;
if (timer >= 2) {
slidV += 7;
timer =0;
}
if (slider.value >= 100) {
           SceneManager.LoadScene(1);
        }

    }
}
