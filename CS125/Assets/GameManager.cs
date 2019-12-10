using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    string time;
    int score = 0;
    int initial = 0;
    public Text a;
    private int i = 0;
    public GameObject missile;
    public int timer;
    private Vector2 position = new Vector2(0,0);
    Quaternion r = new Quaternion(0, 0, 0, 0);
    void Start()
    {        
        initial = -(int)Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        score = (int)((int)Time.time + initial);
        a.text = "Score : " + score; 
        if ((i * timer) < score) {
            Instantiate(missile, position,r);
            i++;
        }
    }
    public void endGame() {
        PlayerPrefs.SetInt("score", score);
        Debug.Log(PlayerPrefs.GetInt("score", -1));
        StartCoroutine(wait());
       
    }
    IEnumerator wait() {
        Destroy(a);
        yield return new WaitForSecondsRealtime(2.25F);
         SceneManager.LoadScene(2);
    }
}
