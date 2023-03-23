using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(-5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
        }
    }
}