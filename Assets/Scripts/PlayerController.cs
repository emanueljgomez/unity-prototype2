using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    public float horizontalInput;
    public float speed = 10.0f;
    public GameObject projectilePrefab; // Component Variable for Player (assign prefab projectile)

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player in bounds
        if (transform.position.x < -28)
        {
            transform.position = new Vector3(-28, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 28)
        {
            transform.position = new Vector3(28, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a proyectile from the Player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            // Instantiate method: creates a copy of a prefab. Formula: Instantiate(Original object, spawn position, rotation)
        }

        // Player horizontal movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
