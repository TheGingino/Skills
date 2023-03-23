using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemymove : MonoBehaviour
{
    private bool moveLeft = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveLeft == true)
        {
            transform.position -= new Vector3(3, 0, 0) * 2 * Time.deltaTime;
        }
        
        if(moveLeft == false)
        {
            transform.position += new Vector3(3, 0, 0) * 2 * Time.deltaTime;
        }

        if(transform.position.x <= -5f)
        {
           moveLeft= false;
           
        }
        if (transform.position.x >= 5f)
        {
            moveLeft = true;
        }
    }
}
