using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tree enemy moves a bit slower than other things.
        if (gameObject.tag == "TreeEnemy") 
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed/2);   
        }
        // Heat enemy and projectile move at the same speed.
        if (gameObject.tag == "HeatEnemy") 
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);   
        } 
        if (gameObject.tag == "SnowballProjectile") 
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);   
        }       
    }
}