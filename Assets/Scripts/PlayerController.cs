using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;
    public float xrange = 22.0f;
    public float zmax = -15.0f;
    public float zmin = -23.0f;
    public float growthFactor;

    public GameObject SnowballProjectile;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starting");
        Time.timeScale = 1;
        growthFactor = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            growthFactor = 0;
        }

        growthFactor += 0.1f;

        // If growthTime is not yet bigger than 0, leave the player size. Else perform scaling.
        float timeScaler = Math.Max(growthFactor/40, 1);
        Vector3 scaling = new Vector3(timeScaler, timeScaler, timeScaler);
        transform.localScale = scaling;

        // Player can drop mass to shoot snowballs at enemies.
        if (Input.GetKeyDown(KeyCode.Space) & timeScaler > 2.5) {
            Instantiate(SnowballProjectile, transform.position, SnowballProjectile.transform.rotation);

            // Decrease mass when firing.
            growthFactor *= 0.8f;
            Vector3 decreasedMass = new Vector3(growthFactor, growthFactor, growthFactor);
            transform.localScale = decreasedMass;
        
        }

        // Define boundaries for the x axis player movement.
        if (transform.position.x < -xrange) {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xrange) {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        // Define boundaries for the y axis player movement.
        if (transform.position.z < zmin) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zmin);
        }
        if (transform.position.z > zmax) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zmax);
        }

        // Adjust the movement of the player based on horizontal and vertical inputs.
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }
}
