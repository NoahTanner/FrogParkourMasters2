using UnityEngine;

public class RotatingSphere : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation
    public GameObject spherePrefab; // Reference to the sphere prefab

    void Update()
    {
        // Rotate the sphere around its local Y axis at 1 degree per second
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object colliding with the sphere is tagged as "Player"
        if(collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            SpawnNewSphere(); // Spawn a new sphere
            Destroy(gameObject); // Destroy the current sphere
        }
    }

    void SpawnNewSphere()
    {
        // Define the bounds within which the new sphere can spawn
        Vector3 randomPosition = new Vector3(Random.Range(-4, 4f), 1f, Random.Range(-4f, 4f));
        
        // Instantiate a new sphere at the random position
        Instantiate(spherePrefab, randomPosition, Quaternion.identity);
    }
}

