using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    // This function is called when another collider enters the trigger collider of the coin
    void OnTriggerEnter(Collider other)
    {
        // Check if the object that collided with the coin has the "Vehicle" tag (or the tag you assigned to your vehicle)
        if (other.CompareTag("Coin"))
        {
            // Destroy the coin object when the vehicle collides with it
            Destroy(gameObject);
        }
    }
}
