using UnityEngine;

public class Objective : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Si detecta una colision con una bala
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Destruye el objetivo
            Destroy(gameObject);
            // Destruye la bala
            Destroy(collision.gameObject);
        }
    }
}
