using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void menuScene (int Level)
 {
  SceneManager.LoadScene (2);
 }

    public void aftorScene (int Level1)
 {
  SceneManager.LoadScene (1);
 }

    public void startScene (int Level2)
 {
  SceneManager.LoadScene (3);
 }
   public void settingScene (int Level3)
 {
  SceneManager.LoadScene (4);
 }
public void gameScene (int Level4)
 {
  SceneManager.LoadScene (5);
 }
 public void Exit()
 {
  Application.Quit ();
 }
}
