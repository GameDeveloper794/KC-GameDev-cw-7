using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : MonoBehaviour
{
    public float speed;
    public Script script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        if(transform.position.z <= 0)
        {
            script.score++;
            transform.position = new Vector3(transform.position.x, transform.position.y, Random.Range(10f, 9f));                                                                                            
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (speed * (script.score + 1)));
    }
}
