using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindFirstObjectByType<GameManager>().GameOver();
            Debug.Log("Collision detected with: " + other.gameObject.name);

        }
    }
}