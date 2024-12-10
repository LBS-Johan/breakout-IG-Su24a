using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovments : MonoBehaviour
{
    public float speed=5;
    public float maxX = 7.5f; 

    float movmentHorizontal; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movmentHorizontal = Input.GetAxis("Horizontal");
        if((movmentHorizontal>0 && transform.position.x<maxX) || (movmentHorizontal<0 && transform.position.x > -maxX))
        {
            transform.position += Vector3.right * movmentHorizontal * speed * Time.deltaTime; 
        }
         
    }
}
