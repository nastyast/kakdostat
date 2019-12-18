using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerr : MonoBehaviour
{
public float GameSeconds;
public float GameMinutes;

string stringSecond;
string stringMinutes;

public Text TextTime;

void Update(){
GameSeconds = GameSeconds+Time.deltaTime;
stringSecond = GameSeconds.ToString();
stringMinutes = GameMinutes.ToString();

TextTime.text = "Таймер-" + stringMinutes + ":" + stringSecond; 
if(GameSeconds>=60.0f) {
GameMinutes = GameMinutes+ 1.0f;
GameSeconds = 0.0f;
}
if (GameMinutes>= 24.0f)
{
GameMinutes = 0.0f;
}
}
}

