using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ui : MonoBehaviour {

public Text text;
   string texta;
   public Text highscoreee;
   int score;
   public int highscore;

   void Start()
   {
       score = PlayerPrefs.GetInt("score", 0);
       Debug.Log(PlayerPrefs.GetInt("score", 0));
       highscore = PlayerPrefs.GetInt("highscore", 0);
   }
void Update() {
    
    texta = "Score : " + PlayerPrefs.GetInt("score", 0);
    highscoreee.text = "Highscore : " + PlayerPrefs.GetInt("highscore", 0);
    text.text = texta;
    if ((PlayerPrefs.GetInt("highscore", 0)) < score) {
        PlayerPrefs.SetInt("highscore", score);
    }
}
 public void PlayGame () 
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
 }
  public void maingame () 
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);
 }
  public void gamegame () 
 {
  SceneManager.LoadScene (1);
 }
 public void QuitGame ()
 {
  Debug.Log ("QUIT!");
  Application.Quit();
 }
  
}