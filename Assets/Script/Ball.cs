using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 3; 
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.one.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y < -5f)
        {
            Destroy(gameObject);
            Gameover(); 
        } 
    }
    void Gameover()
    {
        SceneManager.LoadScene(1); 
    }

} 

