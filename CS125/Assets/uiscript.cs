using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class uiscript : MonoBehaviour
{
    // Start is called before the first frame update
    string time;
    public Text a;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        a.text = "Score : " + (int) Time.time + "s"; 
    }
}
