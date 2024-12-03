using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 5; 

    float movmentHorizontal; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movmentHorizontal = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * movmentHorizontal * speed * Time.deltaTime; 
    }
}
