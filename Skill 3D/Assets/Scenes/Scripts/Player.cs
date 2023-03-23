using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player.transform.position - gameObject.transform.position;
        Vector3 distanceVector = player.transform.position - transform.position ;
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.transform.position, 
            0.1f);
    }
}
