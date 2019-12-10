using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class homingMissile : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    public float speed = 200;
    public Rigidbody2D rigidbody;
    public float rotatespeed = 100f;
    public GameObject explosionEffect;
    bool explode = true;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rigidbody.position;
        direction.Normalize();
        float Roateamount = Vector3.Cross(direction, transform.up).z;
        rigidbody.angularVelocity = - Roateamount * rotatespeed;
        rigidbody.velocity = transform.up * speed;
        if (!explode) {
            Debug.Log("Game ended");
            SceneManager.LoadScene(2);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collisioninfo) {
        if (collisioninfo.tag == "Player") {
            Instantiate (explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(collisioninfo.gameObject);
            explode = false;
            FindObjectOfType<GameManager>().endGame();
        } else if (collisioninfo.tag == "Missile") {
            Instantiate (explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(collisioninfo.gameObject);
            explode = false;
        }
    }
}
