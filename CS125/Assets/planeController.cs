using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeController : MonoBehaviour
{   
    public Joystick joystick;
    public Vector2 Speed = new Vector2(0,0);
    public float speed = 400;
    public float angularSpeed = 1600;
    public float maxAccel = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void rotateLeft() {
        Debug.Log("Happening");
        Vector3 a = new Vector3(0, 0, -1);
        transform.Rotate(a * +1 * angularSpeed);
    }
    public void rotateRight() {
        Vector3 a = new Vector3(0, 0, -1);
        transform.Rotate(a * -1 * angularSpeed * Time.deltaTime);
    }
    void Update()
    {
        float horizontal = joystick.Horizontal;
        Vector3 a = new Vector3(0, 0, -1);
        transform.Rotate(a * horizontal * angularSpeed * Time.deltaTime);
            Speed.y = Mathf.MoveTowards(Speed.y, speed * Time.deltaTime * 0.5f, maxAccel * Time.deltaTime);
            transform.Translate(Speed * Time.deltaTime);
    }
}
