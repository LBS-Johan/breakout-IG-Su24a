using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovments : MonoBehaviour
{

    Rigidbody2D nu; 
    // Start is called before the first frame update
    void Start()
    {
        nu = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        nu.velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            nu.velocity = new Vector2(7, 0); 

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            nu.velocity = new Vector2(-7, 0);

        }
    }
}
