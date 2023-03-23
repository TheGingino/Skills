using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFuel : MonoBehaviour
{
    public GameObject ps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ps.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ps.SetActive(false);
        }
    }
}
