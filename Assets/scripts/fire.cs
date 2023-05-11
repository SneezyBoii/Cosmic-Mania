using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{

    public GameObject projectile; 
    public GameObject bulletPrefab; 
    public float shootInterval = 3f; 
    private float timeSinceLastShot = 0f; 

    void Update()
    {
        // Increase time since last shot
        timeSinceLastShot += Time.deltaTime;

        // Check if it's time to shoot
        if (timeSinceLastShot >= shootInterval)
        {
            // Reset time since last shot
            timeSinceLastShot = 0f;

            // Instantiate a bullet prefab at the current position and rotation of this game object
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
        }
    }

}
