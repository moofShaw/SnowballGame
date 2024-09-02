using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag != "Player")
        {
            if (gameObject.tag == "SnowballProjectile" && other.gameObject.tag == "TreeEnemy")
            {
            Destroy(gameObject); 
            }
            else if (gameObject.tag == "SnowballProjectile" && other.gameObject.tag == "HeatEnemy")
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
