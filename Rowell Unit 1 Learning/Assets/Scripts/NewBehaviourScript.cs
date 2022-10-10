using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class plinkoMovement : MonoBehaviour 
{
    public float speed;
    public Vector3 vector3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randomGen = Random.Range(0, 100);

        if(randomGen == 49)
        {
            float random = Random.Range(-0.1f, 0.1f);
            transform.Translate(random, 0, 0);
        }
       
    }
}

